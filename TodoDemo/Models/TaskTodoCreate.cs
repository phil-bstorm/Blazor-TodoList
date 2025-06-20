using System.ComponentModel.DataAnnotations;

namespace TodoDemo.Models
{
    public class TaskTodoCreate
    {
        [Required]
        [MinLength(3, ErrorMessage = "At lest 3 characters!")]
        [MaxLength(100, ErrorMessage = "No more than 100 characters!")]
        public string Title { get; set; } = "";

        public bool IsCompleted { get; set; } = false;
        
        public string Description { get; set; } = "";
    }
}
