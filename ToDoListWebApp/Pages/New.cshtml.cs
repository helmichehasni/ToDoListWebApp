using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListWebApp.Models;
using ToDoListWebApp.Services;

namespace ToDoListWebApp.Pages
{
    public class NewModel : PageModel
    {
        private readonly ToDoServices toDoServices;

        public ToDo ToDo { get; set; }

        public NewModel(ToDoServices toDoServices)
        {
            this.toDoServices = toDoServices;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await toDoServices.AddAsync(ToDo);
            return LocalRedirect("/list");
        }
    }
}
