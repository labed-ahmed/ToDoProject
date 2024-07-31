using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class CreateViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
