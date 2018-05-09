using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RealEstate.Core
{
    public interface IRepository<T> where T : Entity
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> Get(int id);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Select(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
