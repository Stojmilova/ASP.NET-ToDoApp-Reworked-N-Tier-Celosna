﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;

namespace ToDoApp.WebApp.Models
{
    public class SubTaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TypeStatusSubTask Status { get; set; }       
    }
}
