using Microsoft.EntityFrameworkCore;

namespace TestTemplate.Models.Entities
{
    public class ToDoTaskDbContext : DbContext
    {
        public ToDoTaskDbContext() { }
        public ToDoTaskDbContext(DbContextOptions<ToDoTaskDbContext> options) : base(options) { }
        public DbSet<ToDoTask> ToDoTasks { get; set;}

    }
}
