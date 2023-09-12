using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListWebApp.Models;
using ToDoListWebApp.Services;

namespace ToDoListWebApp.Pages
{
    public class ListModel : PageModel
    {
        private readonly ToDoServices toDoServices;
        public List<ToDo> ToDos { get; set; }
        public ListModel(ToDoServices toDoServices)
        {
            this.toDoServices = toDoServices;
        }
        public async void OnGet()
        {
            ToDos = await toDoServices.GetToDosAsync();
        }
    }
}
