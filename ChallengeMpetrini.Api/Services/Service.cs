using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ChallengeMpetrini.Api.Contracts;
using ChallengeMpetrini.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeMpetrini.Api.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly ContactContext _context;
        public Service(ContactContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> ent = _context.Set<T>().AsQueryable();

            foreach (var property in includeProperties)
                ent = ent.Include(property);

            return predicate == null ? ent : ent.Where(predicate);
        }

        public T GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> ent = _context.Set<T>().AsQueryable();

            foreach (var property in includeProperties)
                ent = ent.Include(property);

            return ent.FirstOrDefault(predicate);
        }

        public T Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Any(predicate);
        }
    }
}
