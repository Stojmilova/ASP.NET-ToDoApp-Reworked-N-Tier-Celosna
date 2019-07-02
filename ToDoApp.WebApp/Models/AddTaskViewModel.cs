using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;

namespace ToDoApp.WebApp.Models
{
    public class AddTaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TypePriority Priority { get; set; }
        public TypeOfTask TypeOfTask { get; set; }
        public TypeStatus Status { get; set; }
        public List<SubTaskViewModel> SubTasks { get; set; }

        
    }
}
