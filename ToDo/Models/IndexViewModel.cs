using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Models
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
