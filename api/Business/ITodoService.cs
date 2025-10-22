using Domain;

namespace Business
{
    public interface ITodoService
    {
        Task CreateTodo(Todo todo);
    }
}
