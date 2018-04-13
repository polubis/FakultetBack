﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PiwoBack.Data.Models;
using PiwoBack.Repository.ApplicationDbContext;
using PiwoBack.Repository.Interfaces;

namespace PiwoBack.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly PiwoDbContext _context;
        private DbSet<T> _dbSet;
        string errorMessage = string.Empty;
        public Repository(PiwoDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query;
        }
        public IEnumerable<T> GetAllBy(Expression<Func<T, bool>> getBy, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var result = query.Where(getBy);
            return result;
        }
        public T GetBy(Expression<Func<T, bool>> getBy, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var result = query.FirstOrDefault(getBy);
            return result;
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Any(expression);
        }
        public int Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = entity.CreationDate = DateTime.Now;
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedDate = DateTime.Now;
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Expression<Func<T, bool>> expression)
        {
            var entity = _dbSet.SingleOrDefault(expression);
            if (entity == null)
            {
                throw new NullReferenceException();
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void GetRelatedCollections(T entity, params Expression<Func<T, IEnumerable<object>>>[] collections)
        {
            foreach (var collection in collections)
            {
                _context.Entry(entity).Collection(collection).Load();
            }
        }
    }
}
