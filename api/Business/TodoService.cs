using Data;
using Domain;

namespace Business;

public class TodoService(ITodoRepository todoRepository) : ITodoService
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<Todo> GetTodo(int todoId)
    {
        return await _todoRepository.GetTodo(todoId);
    }

    public async Task<IEnumerable<Todo>> GetTodos()
    {
        return await _todoRepository.GetTodos();
    }

    public async Task<Todo> CreateTodo(TodoInsert todoInsert)
    {
        var todo = new Todo
        {
            Title = todoInsert.Title,
            Description = todoInsert.Description
        };

        return await _todoRepository.CreateTodo(todo);
    }
}
