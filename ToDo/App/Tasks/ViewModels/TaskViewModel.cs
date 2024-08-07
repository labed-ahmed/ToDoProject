﻿using System.Collections.Generic;
using ToDo.BusinessObjects.Enums;

namespace ToDo.App.Tasks.ViewModels
{
    public class TaskViewModel
    {
        public TaskViewModel() 
        {
            SubTasks = new();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public EnumPriority Priority { get; set; }

        public List<SubTaskViewModel> SubTasks { get; set; }
    }
}
