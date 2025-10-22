using Domain;

namespace Data
{
    public class TodoRepository : ITodoRepository
    {
        public async Task CreateTodo(Todo todo)
        {
            using var db = new TodoContext();

            var entity = await db.AddAsync(todo);
        }
    }
}
