using MSAFocus_TechnicalAssessment.Domain.Entities;

namespace MSAFocus_TechnicalAssessment.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
