using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public class ToDoTaskService : IToDoTaskService
    {
        private IRepository<ToDoTask> _toDoTaskRepository;
       
        public ToDoTaskService(IRepository<ToDoTask> toDoTaskRepo)
        {
            _toDoTaskRepository = toDoTaskRepo;            
        }

        public void AddNewTask(ToDoTask task)
        {
            _toDoTaskRepository.Insert(task);
        }
        
        public List<ToDoTask> GetAllTasks()
        {
           return _toDoTaskRepository.GetAll();
        }

        public ToDoTask GetTaskById(int id)
        {
            return _toDoTaskRepository.GetById(id);
        }
    }
}
