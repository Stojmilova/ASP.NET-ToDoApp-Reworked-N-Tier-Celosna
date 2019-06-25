using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess;
using ToDoApp.Domain.Models;
using ToDoApp.Services.Services;
using ToDoApp.WebApp.Models;

namespace ToDoApp.WebApp.Controllers
{
    public class TaskController : Controller
    {       
        private IUserService _userService;
        private IToDoTaskService _taskService;
        private ISubTaskService _subTaskService;

        public TaskController(IUserService userService, IToDoTaskService taskService, ISubTaskService subTaskService)
        {        
            _userService = userService;
            _taskService = taskService;
            _subTaskService = subTaskService;
        }
        public IActionResult Index()
        {
            List<ListSubTasksViewModel> taskViewModel = new List<ListSubTasksViewModel>();
            var tasks = _taskService.GetAllTasks();
           
            foreach (var task in tasks)
            {
                taskViewModel.Add(new ListSubTasksViewModel()
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
        
        public IActionResult NotDoneTasks(int? id)
        {
            User user = _userService.GetAll().SingleOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult InProgressTasks(int? id)
        {
            User user = _userService.GetAll().SingleOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult DoneTasks(int? id)
        {
            User user = _userService.GetAll().SingleOrDefault(x => x.Id == id);            
            return View(user);
        }

        public IActionResult UserStatistics(int? id)
        {
            User user = _userService.GetAll().SingleOrDefault(x => x.Id == id);
            return View(user);
        }
        [HttpGet("AddNewTask")]
        public IActionResult AddNewTask(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            TasksViewModel model = new TasksViewModel();
            return View(model);
        }
        [HttpPost("AddNewTask")]
        public IActionResult AddNewTask(TasksViewModel model)
        {
            ToDoTask task = new ToDoTask()
            {
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TaskType = model.TaskType,
            };
            _taskService.AddNewTask(task);//Add task in _taskService;

            SubTask subtask = new SubTask()
            {               
                Title = model.TitleSubTask,
                Description = model.DescriptionSubTask,
                Status = model.StatusSubTask,
            };
            task.SubTasks.Add(subtask);//Add subtask in SubTasks-List of task;

            User user = _userService.GetUserById(3);//Add task to login user - Megan Morton;
            user.CreatedTasks.Add(task);

            return View("_AddedTask");
        }
        [HttpGet]
        public IActionResult DetailsTask(int? id)
        {
            var task = _taskService.GetAllTasks().SingleOrDefault(x => x.Id == id);
            var subTasks = _subTaskService.GetAll().Where(x => x.TaskID == task.Id).ToList();
         
            ListSubTasksViewModel model = new ListSubTasksViewModel()
            {              
                Title = task.Title,
                Description = task.Description,
                Priority = task.Priority,
                Status = task.Status,
                TaskType = task.TaskType,
                SubTasks = subTasks
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult DetailsTask(ListSubTasksViewModel model)
        {           
            List<SubTask> subTasks = _subTaskService.GetAll().Where(x => x.TaskID == model.Id).ToList();

            ToDoTask task = new ToDoTask()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TaskType = model.TaskType,
                SubTasks = subTasks
            };
            _taskService.AddNewTask(task);

            return View(subTasks);
        }

    }
}