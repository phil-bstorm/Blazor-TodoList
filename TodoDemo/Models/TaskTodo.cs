namespace TodoDemo.Models
{
    public class TaskTodo
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string Description { get; set; } = "";
    }
}
