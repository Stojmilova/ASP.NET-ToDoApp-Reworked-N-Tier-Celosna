using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using ToDoApp.Services.Services;
using ToDoApp.WebApp.Models;

namespace ToDoApp.WebApp.Controllers
{
    public class TaskController : Controller
    {

        private IToDoTaskService _taskService;
        private IUserService _userService;
        private ISubTaskService _subTaskService;

        public TaskController(IUserService userService, IToDoTaskService taskService, ISubTaskService subTaskService)
        {
            _userService = userService;
            _taskService = taskService;
            _subTaskService = subTaskService;

        }
        public IActionResult Index()
        {
            List<AllTasksViewModel> taskViewModel = new List<AllTasksViewModel>();
            var tasks = _taskService.GetAllTasks();

            foreach (var task in tasks)
            {
                taskViewModel.Add(new AllTasksViewModel()
                {
                    Title = task.Title,
                    Description = task.Description,
                    Priority = task.Priority,
                    Status = task.Status,
                    TaskType = task.TaskType,
                    SubTasks = task.SubTasks
                });
            }

            return View(taskViewModel);

        }
        public IActionResult NotDoneTasks()
        {
            List<ToDoTask> allNotDoneTasks = _taskService.GetAllTasks().Where(x => x.Status == TypeStatus.NotDone).ToList();
            foreach (var task in allNotDoneTasks)
            {
                foreach (var subtask in _subTaskService.GetAll().Where(x => x.TaskID == task.Id))
                {
                    task.SubTasks.Add(subtask);
                }
            };
            ToDoTaskViewModel model = new ToDoTaskViewModel()
            {
                Tasks = allNotDoneTasks
            };

            return View(model);
        }

        public IActionResult InProgressTasks()
        {
            List<ToDoTask> allInProgressTasks = _taskService.GetAllTasks().Where(x => x.Status == TypeStatus.InProgress).ToList();
            foreach (var task in allInProgressTasks)
            {
                foreach (var subtask in _subTaskService.GetAll().Where(x => x.TaskID == task.Id))
                {
                    task.SubTasks.Add(subtask);
                }
            };
            ToDoTaskViewModel model = new ToDoTaskViewModel()
            {
                Tasks = allInProgressTasks
            };

            return View(model);
        }

        public IActionResult DoneTasks()
        {
            List<ToDoTask> allDoneTasks = _taskService.GetAllTasks().Where(x => x.Status == TypeStatus.Done).ToList();
            foreach (var task in allDoneTasks)
            {
                foreach (var subtask in _subTaskService.GetAll().Where(x => x.TaskID == task.Id))
                {
                    task.SubTasks.Add(subtask);
                }
            };
            ToDoTaskViewModel model = new ToDoTaskViewModel()
            {
                Tasks = allDoneTasks
            };

            return View(model);
        }
        [Route("Task/UserStatistics/{id}")]
        public IActionResult UserStatistics(int? id)
        {
            User user = _userService.GetAll().FirstOrDefault(x => x.Id == id);
            return View(user);
        }
        [HttpGet]
        public IActionResult AddSubTask()
        {
            return View(new AddSubTaskViewModel());
        }

        [HttpPost]
        public IActionResult AddSubTask(AddSubTaskViewModel model)
        {
            return RedirectToAction("AddTask", "Task", new { subtasks = model.NumberOfSubTask });
        }
        [HttpGet]
        [Route("Task/AddTask/{subtasks}")]
        public IActionResult AddTask(string error, [FromRoute]int? subtasks)
        {
            if (error != null) return View("_Error");
            AddTaskViewModel modelToDo = new AddTaskViewModel();
            modelToDo.SubTasks = new List<SubTaskViewModel>();
            for (int i = 0; i < subtasks.Value; i++)
            {
                modelToDo.SubTasks.Add(new SubTaskViewModel());
            }
            return View(modelToDo);
        }
        [HttpPost]
        public IActionResult AddTask(AddTaskViewModel model)
        {
            List<SubTask> subtasks = new List<SubTask>();
            foreach (var subtask in model.SubTasks)
            {
                subtasks.Add(new SubTask()
                {
                    Title = subtask.Title,
                    Description = subtask.Description,
                    Status = subtask.Status
                });
            }
            ToDoTask todo = new ToDoTask()
            {
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TaskType = model.TypeOfTask,
                SubTasks = subtasks
            };
            _taskService.AddNewTask(todo);

            return View("_AddedTask");
        }


        [HttpGet]
        [Route("Task/DetailsTask/{id}")]
        public IActionResult DetailsTask(int id)
        {

            ToDoTask task = _taskService.GetAllTasks().FirstOrDefault(x => x.Id == id);

            List<SubTaskViewModel> allSubTasks = new List<SubTaskViewModel>();
            foreach (SubTask subtask in task.SubTasks)
            {
                allSubTasks.Add(new SubTaskViewModel()
                {
                    Id = subtask.Id,
                    Title = subtask.Title,
                    Description = subtask.Description,
                    Status = subtask.Status
                });

            }

            TaskViewModel model = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Priority = task.Priority,
                Status = task.Status,
                TaskType = task.TaskType,
                SubTasks = allSubTasks
            };

            return View(model);
        }
        [HttpPost]
        [Route("Task/DetailsTask/{model}")]
        public IActionResult DetailsTask(TaskViewModel model)
        {
            ToDoTask todo = _taskService.GetAllTasks().FirstOrDefault(t => t.Id == model.Id);

            List<SubTaskViewModel> allSubTasks = new List<SubTaskViewModel>();
            foreach (var subTask in model.SubTasks)
            {
                allSubTasks.Add(subTask);
            }

            // MAPPING SECTION

            //To SubTask
            List<SubTask> subtasks = new List<SubTask>();
            foreach (var subTask in allSubTasks)
            {
                subtasks.Add(new SubTask()
                {
                    Id = subTask.Id,
                    Title = subTask.Title,
                    Description = subTask.Description,
                    Status = subTask.Status,
                });
            }
            //To ToDoTask
            ToDoTask task = new ToDoTask()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TaskType = model.TaskType,
                SubTasks = subtasks
            };

            _taskService.UpdateTask(task);

            return View("_EditDetailsView");
        }
    }
}