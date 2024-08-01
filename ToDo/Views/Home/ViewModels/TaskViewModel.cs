using System.Collections.Generic;
using ToDo.BusinessObjects.Enums;
using ToDo.BusinessObjects;

namespace ToDo.Views.Home.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public EnumPriority Priority { get; set; }

        public List<SubTask> SubTasks { get; set; }
    }
}
