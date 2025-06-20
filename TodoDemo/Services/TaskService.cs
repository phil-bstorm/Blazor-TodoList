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

        public Task<List<TaskTodo>> GetTask() {
            return Task.FromResult(TaskList); // plus tard, ça sera un HttpClient
        }

        public Task<TaskTodo?> GetTaskById(int id) {
            TaskTodo? t = TaskList.FirstOrDefault(t => t.Id == id);
            return Task.FromResult(t);
        }

        public Task<bool> Create(TaskTodo t) {
            if (t.Id == 0)
            {
                t.Id = TaskList.Count + 1; // pas très propre, mais ça marche
            }
            TaskList.Add(t);
            return Task.FromResult(true);
        }
    }
}
