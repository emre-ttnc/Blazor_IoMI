using Inspection_of_Measuring_Instruments.Application.Repositories;
using Inspection_of_Measuring_Instruments.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly IoMIDbContext _context;

    public WriteRepository(IoMIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry<T> entry = await Table.AddAsync(entity);
        return entry.State == EntityState.Added;
    }

    public bool Delete(T entity)
    {
        EntityEntry<T> entry = Table.Remove(entity);
        return entry.State == EntityState.Deleted;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        T? entity = await Table.FirstOrDefaultAsync(t => t.Id == id);
        if (entity is null)
            return false;
        return Delete(entity);
    }

    public bool Update(T entity)
    {
        EntityEntry<T> entry = Table.Update(entity);
        return entry.State == EntityState.Modified;
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}