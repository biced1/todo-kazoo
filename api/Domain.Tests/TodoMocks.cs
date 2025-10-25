namespace Domain.Tests;

public static class TodoMocks
{
    public static readonly Todo TEST_TODO = new()
    {
        Id = 1,
        Title = "Test Title",
        Description = "Test Description"
    };

    public static readonly TodoInsert TEST_TODO_INSERT = new()
    {
        Title = "Test Title",
        Description = "Test Description"
    };
}
