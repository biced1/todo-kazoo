using Domain;

namespace Business;

public interface ITodoService
{
    Task<IEnumerable<Todo>> GetTodos();
    Task<Todo> GetTodo(int todoId);
    Task<Todo> CreateTodo(TodoInsert todoInsert);
}
