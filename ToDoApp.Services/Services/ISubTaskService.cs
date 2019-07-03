using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public interface ISubTaskService
    {
        void AddNewSubTask(SubTask entity);
        List<SubTask> GetAll();
       
    }
}
