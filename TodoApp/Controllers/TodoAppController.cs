using Microsoft.AspNetCore.Mvc;
using TodoApp.Models.Request;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoAppController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoAppController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = new List<string>
            {
                "Buy groceries",
                "Walk the dog",
                "Finish homework"
            };
            return Ok(todos);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateTodoRequest request)
        {
            var result = _todoService.CreateTodo(request);
            return Ok(result);
        }
    }
}
