using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public class SubTaskService : ISubTaskService
    {
        private IRepository<SubTask> _subTaskRepository;

        public SubTaskService(IRepository<SubTask> subTaskRepository)
        {
            _subTaskRepository = subTaskRepository;
        }

        public void AddNewSubTask(SubTask entity)
        {
            _subTaskRepository.Insert(entity);
        }

        public List<SubTask> GetAll()
        {
            return _subTaskRepository.GetAll();
        }
    }
}
