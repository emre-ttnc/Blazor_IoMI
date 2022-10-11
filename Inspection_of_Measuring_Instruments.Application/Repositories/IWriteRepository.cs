using Inspection_of_Measuring_Instruments.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inspection_of_Measuring_Instruments.Application.Repositories;

public interface IWriteRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }

    Task<bool> AddAsync(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    Task<bool> DeleteAsync(Guid id);
    Task SaveAsync();
}