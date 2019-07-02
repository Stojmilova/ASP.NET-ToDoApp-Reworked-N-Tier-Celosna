using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;

namespace ToDoApp.WebApp.Models
{
    public class TasksViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Title of Task")]
        public string Title { get; set; }
        [Display(Name = "Description of Task")]
        public string Description { get; set; }
        public TypePriority Priority { get; set; }
        public TypeStatus Status { get; set; }
        public TypeOfTask TaskType { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Title of Subtask")]
        public string TitleSubTask { get; set; }
        [Display(Name = "Description of Subtask")]
        public string DescriptionSubTask { get; set; }
        public TypeStatusSubTask StatusSubTask { get; set; }
      
    }
}
