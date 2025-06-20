using Microsoft.AspNetCore.Components;
using TodoDemo.Models;
using TodoDemo.Services;

namespace TodoDemo.Pages
{
    public partial class Tasks
    {
        [Inject]
        public TaskService TaskService { get; set; } = null!;

        public List<TaskTodo>? TaskList { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Tasks component OnInitializedAsync");
            TaskList = await TaskService.GetTask();
        }

        public void DeleteTask(TaskTodo t)
        {
            Console.WriteLine($"Deleting task: {t.Title}");
            TaskService.DeleteTask(t);
            //TaskList = TaskList?.Where(task => task.Id != t.Id).ToList(); // non-nécessaire car passage par référence
        }
    }
}
