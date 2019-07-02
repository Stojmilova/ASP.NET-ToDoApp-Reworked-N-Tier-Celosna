using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public interface IToDoTaskService
    {
        List<ToDoTask> GetAllTasks();
        ToDoTask GetTaskById(int id);
        void AddNewTask(ToDoTask task);
        void UpdateTask(ToDoTask task);
    }
}
