using Business;
using Domain;
using Domain.Tests;
using Moq;
using Web.Controllers;

namespace Web.Tests.Controllers;

internal class TodoControllerTests
{
    private Mock<ITodoService> _todoServiceMock;
    private TodoController _todoController;

    [SetUp]
    public void Setup()
    {
        _todoServiceMock = new Mock<ITodoService>();
        _todoController = new TodoController(_todoServiceMock.Object);
    }

    [Test]
    public async Task GetTodo_GetsTodo_Successfully()
    {
        _todoServiceMock.Setup(x => x.GetTodo(TodoMocks.TEST_TODO.Id))
            .ReturnsAsync(TodoMocks.TEST_TODO);

        var actual = await _todoController.GetTodo(TodoMocks.TEST_TODO.Id);

        Assert.That(actual, Is.EqualTo(TodoMocks.TEST_TODO));
    }

    [Test]
    public async Task GetTodos_GetsTodos_Successfully()
    {
        _todoServiceMock.Setup(x => x.GetTodos())
            .ReturnsAsync(new List<Todo> { TodoMocks.TEST_TODO });

        var actual = await _todoController.GetTodos();

        Assert.That(actual.First(), Is.EqualTo(TodoMocks.TEST_TODO));
    }

    [Test]
    public async Task CreateTodo_CreatesTodo_Successfully()
    {
        _todoServiceMock.Setup(x => x.CreateTodo(TodoMocks.TEST_TODO_INSERT))
            .ReturnsAsync(TodoMocks.TEST_TODO);

        var actual = await _todoController.CreateTodo(TodoMocks.TEST_TODO_INSERT);

        Assert.That(actual, Is.EqualTo(TodoMocks.TEST_TODO));
    }
}
