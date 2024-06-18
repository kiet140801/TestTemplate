using System.ComponentModel.DataAnnotations;

namespace TestTemplate.Models.Entities
{
    public class ToDoTask
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}
