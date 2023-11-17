using System;
using System.Linq.Expressions;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T>
	{
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 
    }
}

