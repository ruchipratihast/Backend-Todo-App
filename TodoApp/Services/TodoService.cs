using Microsoft.EntityFrameworkCore;
using TodoApp.Models.Database;
using TodoApp.Models.Request;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly EFCoreDbContext _dbContext;

        public TodoService(EFCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TodoModel>> GetTodos()
        {

            var todos = await _dbContext.TodoModel.ToListAsync();

            return todos;
        }
        public async Task<bool> CreateTodo(CreateTodoRequest bodyDatas)
        {
            var todo = new TodoModel
            {
             TaskName = bodyDatas.TaskName,
             DueDate = bodyDatas.DueDate,
             IsCompleted = bodyDatas.IsCompleted,
            };

            _dbContext.TodoModel.Add(todo);

            // Use SaveChangesAsync for proper async flow
            var result = await _dbContext.SaveChangesAsync();

            // Returns true if at least one row was affected
            return result > 0;
        }
    }
}
