using Domain;

namespace Data
{
    public interface ITodoRepository
    {
        Task CreateTodo(Todo todo);
    }
}
