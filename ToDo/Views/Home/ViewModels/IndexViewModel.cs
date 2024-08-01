using System.Collections.Generic;

namespace ToDo.Views.Home.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Tasks = new();
        }
        public List<TaskViewModel> Tasks { get; set; }
    }
}
