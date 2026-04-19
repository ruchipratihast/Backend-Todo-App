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

        [HttpGet("status/{isCompleted}")]
        public async Task<IActionResult> GetTodosByStatus(bool isCompleted) 
        {
            var data = await _todoService.GetTodosByStatus(isCompleted);
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

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTodoRequest request)
        {
            var result = await _todoService.UpdateTodo(request);
            if (result)
            {
                return Ok(new { Message = "Todo updated successfully" });
            }
            else
            {
                return BadRequest(new { Message = "Todo Not found" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _todoService.DeleteTodo(id);
            if (result)
            {
                return Ok(new { Message = "Todo deleted successfully" });
            }
            else
            {
                return BadRequest(new { Message = "Todo Not found" });
            }
        }
    }
}
