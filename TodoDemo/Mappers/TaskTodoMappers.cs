using TodoDemo.Models;

namespace TodoDemo.Mappers
{
    public static class TaskTodoMappers
    {
        public static TaskTodo ToTaskTodo(this TaskTodoCreate model) {
            return new TaskTodo
            {
                Title = model.Title,
                IsCompleted = model.IsCompleted,
                Description = model.Description,
            };
        }
    }
}
