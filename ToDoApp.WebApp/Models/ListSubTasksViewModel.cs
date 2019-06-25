using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;

namespace ToDoApp.WebApp.Models
{
    public class ListSubTasksViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TypePriority Priority { get; set; }
        public TypeStatus Status { get; set; }
        public TypeOfTask TaskType { get; set; }
        public List<SubTask> SubTasks { get; set; }
    }
}
