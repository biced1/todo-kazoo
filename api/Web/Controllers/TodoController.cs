using Business;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace TodoKazooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public Todo GetTodo()
        {
            return new Todo();
        }

        [HttpPost]
        public async Task CreateTodo(Todo todo)
        {
            await _todoService.CreateTodo(todo);
        }

        [HttpPut]
        public void UpdateTodo(Todo todo)
        {

        }

        [HttpPut("{todoId}")]
        public void CompleteTodo(int todoId)
        {

        }

        [HttpDelete("{todoId}")]
        public void DeleteTodo(int todoId) 
        { 
        
        }
    }
}
