using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Models;

namespace ToDoApp.WebApp.Models
{
    public class ToDoTaskViewModel
    {
        public List<ToDoTask> Tasks { get; set; }
    }
}
