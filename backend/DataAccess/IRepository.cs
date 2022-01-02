using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities;

namespace DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
