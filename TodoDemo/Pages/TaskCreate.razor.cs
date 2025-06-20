using Microsoft.AspNetCore.Components;
using TodoDemo.Mappers;
using TodoDemo.Models;
using TodoDemo.Services;

namespace TodoDemo.Pages
{
    public partial class TaskCreate
    {
        [Inject]
        public TaskService TaskService { get; set; } = null!;
        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        public TaskTodoCreate Model { get; set; } = new TaskTodoCreate();

        public async Task OnSubmit() {
            Console.WriteLine(Model.Title);

            await TaskService.Create(Model.ToTaskTodo());
            NavigationManager.NavigateTo("/tasks");
        }
    }
}
