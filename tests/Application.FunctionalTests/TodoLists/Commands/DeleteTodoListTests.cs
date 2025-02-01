using MSAFocus_TechnicalAssessment.Application.TodoLists.Commands.CreateTodoList;
using MSAFocus_TechnicalAssessment.Application.TodoLists.Commands.DeleteTodoList;
using MSAFocus_TechnicalAssessment.Domain.Entities;

namespace MSAFocus_TechnicalAssessment.Application.FunctionalTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
