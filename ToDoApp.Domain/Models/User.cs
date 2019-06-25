using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal AverageFreeTime { get; set; }
        public List<ToDoTask> CreatedTasks { get; set; }
        public string Email { get; set; }
        public int TaskId { get; set; }

        public User()
        {
            CreatedTasks = new List<ToDoTask>();
        }
    }
}
