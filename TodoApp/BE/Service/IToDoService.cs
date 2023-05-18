using Assignment2.Models;

namespace Assignment2.Service
{
    public interface IToDoService
    {
        Task<Todo> GetNextTodoByIdAsync(int id);
        Task<Todo> GetFirstTodoByIdAsync(int id);
    }
}
