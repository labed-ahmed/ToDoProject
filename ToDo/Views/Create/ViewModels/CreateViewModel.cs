using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ToDo.BusinessObjects.Enums;
using ToDo.BusinessObjects;

namespace ToDo.Views.Create.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

		public EnumPriority Priority { get; set; }

		public List<SubTask> SubTasks { get; set; }
	}
}
