using Inspection_of_Measuring_Instruments.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Inspection_of_Measuring_Instruments.Application.Repositories;

public interface IReadRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get;}
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(Guid id);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
}