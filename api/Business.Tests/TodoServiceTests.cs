using Data;
using Domain;
using Domain.Tests;
using Moq;

namespace Business.Tests;

public class Tests
{
    private Mock<ITodoRepository> _todoRepositoryMock;
    private TodoService _todoService;

    [SetUp]
    public void Setup()
    {
        _todoRepositoryMock = new Mock<ITodoRepository>();
        _todoService = new TodoService(_todoRepositoryMock.Object);
    }

    [Test]
    public async Task GetTodo_GetsTodo_Successfully()
    {
        _todoRepositoryMock.Setup(x => x.GetTodo(TodoMocks.TEST_TODO.Id))
            .ReturnsAsync(TodoMocks.TEST_TODO);

        var actual = await _todoService.GetTodo(TodoMocks.TEST_TODO.Id);

        Assert.That(actual, Is.EqualTo(TodoMocks.TEST_TODO));
    }

    [Test]
    public async Task GetTodos_GetsTodos_Successfully()
    {
        _todoRepositoryMock.Setup(x => x.GetTodos())
            .ReturnsAsync(new List<Todo> { TodoMocks.TEST_TODO });

        var actual = await _todoService.GetTodos();

        Assert.That(actual.First(), Is.EqualTo(TodoMocks.TEST_TODO));
    }

    [Test]
    public async Task CreateTodo_CreatesTodo_Successfully()
    {
        _todoRepositoryMock.Setup(x => x.CreateTodo(It.IsAny<Todo>()))
            .ReturnsAsync(TodoMocks.TEST_TODO);

        var actual = await _todoService.CreateTodo(TodoMocks.TEST_TODO_INSERT);

        Assert.That(actual, Is.EqualTo(TodoMocks.TEST_TODO));
    }
}