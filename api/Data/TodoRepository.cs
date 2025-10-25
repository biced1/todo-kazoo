using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class TodoRepository : ITodoRepository
{
    public TodoRepository()
    {
        using var db = new TodoContext();
        db.Database.EnsureCreated(); //TODO can we move this to app startup
    }

    public async Task<Todo> GetTodo(int todoId)
    {
        using var db = new TodoContext();

        return await db.Todos.SingleAsync(t => t.Id == todoId);
    }

    public async Task<IEnumerable<Todo>> GetTodos()
    {
        using var db = new TodoContext();

        return await db.Todos.ToListAsync();
    }

    public async Task<Todo> CreateTodo(Todo todo)
    {
        using var db = new TodoContext();

        var entity = await db.Todos.AddAsync(todo);
        await db.SaveChangesAsync();

        return entity.Entity;
    }
}
