using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        IEnumerable<T> GetAllBy(Expression<Func<T, bool>> getBy, params Expression<Func<T, object>>[] includes);
        T GetBy(Expression<Func<T, bool>> getBy, params Expression<Func<T, object>>[] includes);
        bool Exist(Expression<Func<T, bool>> expression);
        int Insert(T entity);
        void Update(T entity);
        void Delete(Expression<Func<T, bool>> expression);

        void GetRelatedCollections(T entity, params Expression<Func<T, IEnumerable<object>>>[] collections);
    }
}
