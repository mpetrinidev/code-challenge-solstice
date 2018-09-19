using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ChallengeMpetrini.Api.Contracts
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        T Add(T entity);
        T GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        T Update(T entity);
        void Delete(T entity);
        bool Exists(Expression<Func<T, bool>> predicate);
    }
}
