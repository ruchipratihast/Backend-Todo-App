using TodoApp.Models.Request;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        public Task<CreateTodoRequest> CreateTodo(CreateTodoRequest bodyDatas)
        {
            return Task.FromResult(bodyDatas);
        }
    }
}
