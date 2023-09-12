using System.ComponentModel.DataAnnotations;

namespace ToDoListWebApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public Status status { get; set; } = Status.Created;
    }
}

