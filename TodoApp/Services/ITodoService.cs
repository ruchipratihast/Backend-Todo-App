using TodoApp.Models.Database;
using TodoApp.Models.Request;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetTodos();
        Task<bool> CreateTodo(CreateTodoRequest bodyDatas);
        Task<bool> UpdateTodo(UpdateTodoRequest bodyDatas);
        Task<bool> DeleteTodo(Guid id);
        Task<List<TodoModel>> GetTodosByStatus(bool isCompleted);
    }
}
