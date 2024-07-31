using System;

namespace ToDo.BusinessObjects
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime ModificationDate { get; set; } = DateTime.Now;
    }
}
