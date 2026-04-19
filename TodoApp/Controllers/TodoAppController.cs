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
        public async Task<IActionResult> GetTodos()
        {
            var data = await _todoService.GetTodos();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTodoRequest request)
        {
            var result = await _todoService.CreateTodo(request);
            if (result)
            {
                return Ok(new { Message = "Todo created successfully" });
            }
            else
            {
                return BadRequest(new { Message = "Failed to create todo" });
            }
        }
    }
}
