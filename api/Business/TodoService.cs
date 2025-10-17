using Data;
using Domain;

namespace Business
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task CreateTodo(Todo todo)
        {
            await _todoRepository.CreateTodo(todo);
        }
    }
}
