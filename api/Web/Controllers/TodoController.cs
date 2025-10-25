using Business;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TodoKazooApi.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("{todoId}")]
        public async Task<Todo> GetTodo(int todoId)
        {
            return await _todoService.GetTodo(todoId);
        }

        [HttpGet]
        public async Task<IEnumerable<Todo>> GetTodos()
        {
            return await _todoService.GetTodos();
        }


        [HttpPost]
        public async Task<Todo> CreateTodo(TodoInsert todo)
        {
            return await _todoService.CreateTodo(todo);
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
