using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { 
        }

        public DbSet<Todo> Todos { get; set; } = null;
    }
}
    