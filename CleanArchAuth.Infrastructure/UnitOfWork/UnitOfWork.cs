using CleanArchAuth.Domain.Entities;
using CleanArchAuth.Domain.Interfaces;
using CleanArchAuth.Infrastructure.Data;
using CleanArchAuth.Infrastructure.Reponsitory;

namespace CleanArchAuth.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private IReponsitory<ApplicationUser> _users;

    public UnitOfWork(ApplicationDbContext context, IReponsitory<ApplicationUser> users)
    {
        _context = context;
        // _users = users ?? throw new ArgumentNullException(nameof(users));
    }

    public IReponsitory<ApplicationUser> Users => _users ??= new Reponsitory<ApplicationUser>(_context);

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
