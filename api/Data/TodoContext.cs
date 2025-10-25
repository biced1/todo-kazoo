using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;

internal class TodoContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public string DbPath { get; }

    public TodoContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "todo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .Property(b => b.Id)
            .UseIdentityColumn();
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
