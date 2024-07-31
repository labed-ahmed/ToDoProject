using System.ComponentModel.DataAnnotations;

namespace ToDo.BusinessObjects
{
    public class SubTask : BaseModel
    {
        public string Title { get; set; }

        public bool Checked { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
