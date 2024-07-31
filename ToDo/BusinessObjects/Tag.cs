using System.ComponentModel.DataAnnotations;

namespace ToDo.BusinessObjects
{
    public class Tag : BaseModel
    {
        public string Title { get; set; }

        public string Color { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
