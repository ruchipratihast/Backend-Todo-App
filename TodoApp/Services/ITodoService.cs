using TodoApp.Models.Request;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        public Task<CreateTodoRequest> CreateTodo(CreateTodoRequest bodyDatas);
    }
}
