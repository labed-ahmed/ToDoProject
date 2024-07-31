using System.ComponentModel.DataAnnotations;

namespace ToDo.BusinessObjects
{
    public class Attachment : BaseModel
    {
        public string Name { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
