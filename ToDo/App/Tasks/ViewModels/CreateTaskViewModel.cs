﻿using System.Collections.Generic;
using ToDo.BusinessObjects.Enums;
using ToDo.BusinessObjects;

namespace ToDo.App.Tasks.ViewModels
{
    public class CreateTaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

		public EnumPriority Priority { get; set; }

		public List<SubTask> SubTasks { get; set; }

	}
}
