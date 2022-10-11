using Inspection_of_Measuring_Instruments.Application.Repositories;
using Inspection_of_Measuring_Instruments.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly IoMIDbContext _context;

    public ReadRepository(IoMIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll() => Table;

    public async Task<T> GetByIdAsync(Guid id) => await GetSingleAsync(t => t.Id == id);
    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate) => await Table.FirstOrDefaultAsync(predicate);

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate) => Table.Where(predicate);
}