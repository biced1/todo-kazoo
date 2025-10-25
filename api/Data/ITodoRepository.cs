using Domain;

namespace Data
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetTodos();
        Task<Todo> GetTodo(int todoId);
        Task<Todo> CreateTodo(Todo todo);
    }
}
