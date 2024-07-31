using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ToDo.BusinessObjects.Enums;

namespace ToDo.BusinessObjects
{
    public class Task : BaseModel
    {
        public Task()
        {
            SubTasks = new();
            Tags = new();
            Attachments = new();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public EnumPriority Priority { get; set; }

        public List<SubTask> SubTasks { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Attachment> Attachments { get; set; }
    }
}
