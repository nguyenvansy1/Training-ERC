using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class ToDoSqlRepository
    {

        private readonly TodoContext _context;

        public ToDoSqlRepository(TodoContext context)
        {
            _context = context;
        }
        private void MoveTop(int id, string action)
        {
           TodoItem firstTask = 
        }
    }
}
