﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DMS.Infrastructure.Repositories
{
    public abstract class GenericRepository<T>
        : IRepository<T> where T : class
    {
        protected DmsDbContext context;

        public GenericRepository(DmsDbContext context)
        {
            this.context = context;
        }

        public virtual T Add(T entity)
        {
            return context
                .Add(entity)
                .Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual IEnumerable<T> All()
        {
            return context.Set<T>()
                .ToList();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity)
                .Entity;
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
        }

        public virtual IEnumerable<T> Reorder(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>()
                .OrderBy(predicate)
                .ToList();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
