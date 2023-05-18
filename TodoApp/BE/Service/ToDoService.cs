using Assignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Service
{
    public class ToDoService : IToDoService
    {
        private readonly ToDoContext _context;

        public ToDoService(ToDoContext context)
        {
            _context = context;
        }

        public async Task<Todo> GetNextTodoByIdAsync(int id)
        {
            var next = await _context.Todos.FirstOrDefaultAsync(i => i.Id > id);
            return next;
        }

        public async Task<Todo> GetFirstTodoByIdAsync(int id)
        {
            var next = await _context.Todos.FirstOrDefaultAsync();
            return next;
        }
    }
}
