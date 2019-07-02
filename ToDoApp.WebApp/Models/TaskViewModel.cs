using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;

namespace ToDoApp.WebApp.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }      
        public string Title { get; set; }     
        public string Description { get; set; }
        public TypePriority Priority { get; set; }
        public TypeStatus Status { get; set; }
        public TypeOfTask TaskType { get; set; }
        public List<SubTaskViewModel> SubTasks { get; set; }

        public TaskViewModel()
        {
            SubTasks = new List<SubTaskViewModel>();
        }
    }
}
