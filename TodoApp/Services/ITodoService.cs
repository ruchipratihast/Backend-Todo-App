using TodoApp.Models.Database;
using TodoApp.Models.Request;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetTodos();
        Task<bool> CreateTodo(CreateTodoRequest bodyDatas);
    }
}
