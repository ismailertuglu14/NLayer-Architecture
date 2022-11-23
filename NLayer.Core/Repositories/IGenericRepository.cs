using System;
using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
		Task<T> GetByIdAsync(int id);
        //productRepository.where(x=>x.id > 5) T = x , bool = x.id > 5 mi 5 se al
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

