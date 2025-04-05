using System;
using System.Linq.Expressions;

namespace ViralRadar.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
     
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
    
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
    }
}

