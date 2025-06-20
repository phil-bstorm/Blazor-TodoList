using TodoDemo.Models;

namespace TodoDemo.Services
{
    public class TaskService
    {
        List<TaskTodo> TaskList = new List<TaskTodo>
        {
            new TaskTodo { Id = 1, Title = "Buy groceries", Description = "Va au magasin!" },
            new TaskTodo { Id = 2, Title = "Walk the dog", Description = "Promene Nala" },
            new TaskTodo { Id = 3, Title = "Read a book", Description = "Lis le \"Seigneur des Anneaux\"", IsCompleted = true }
        };

        public void DeleteTask(TaskTodo t)
        {
            TaskList.Remove(t);
        }
    }
}
