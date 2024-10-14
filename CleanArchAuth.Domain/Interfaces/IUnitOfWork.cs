using CleanArchAuth.Domain.Entities;

namespace CleanArchAuth.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IReponsitory<ApplicationUser> Users { get; }
    Task<int> SaveAsync();
}
