using CleanArchAuth.Domain.Interfaces;
using CleanArchAuth.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchAuth.Infrastructure.Reponsitory;

public class Reponsitory<T> : IReponsitory<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _entities;

    public Reponsitory(ApplicationDbContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _context.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _entities.FindAsync(id);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}
