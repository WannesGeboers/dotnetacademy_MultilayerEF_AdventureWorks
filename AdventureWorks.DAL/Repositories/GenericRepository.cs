using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AdventureWorks.DAL
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
      
        public GenericRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        //public virtual IEnumerable<TEntity> Get(
        //    Expression<Func<TEntity, bool>> filter = null,
        //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //    string includeProperties = "")
        //{
        //    IQueryable<TEntity> query = _context.Set<TEntity>();
        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }
        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }
        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList();
        //    }
        //    else
        //    {
        //        return query.ToList();
        //    }
        //}
        public virtual TEntity GetByID(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public virtual void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        //public virtual void Delete(object id)
        //{
        //    TEntity entityToDelete = _context.Set<TEntity>().Find(id);
        //    Delete(entityToDelete);
        //}
        //public virtual void Delete(TEntity entityToDelete)
        //{
        //    ////if (_context.Set<TEntity>().Entry(entityToDelete).State == EntityState.Detached)
        //    ////{
        //    ////    _context.Set<TEntity>().Attach(entityToDelete);
        //    ////}
        //    _context.Set<TEntity>().Remove(entityToDelete);
        //}


        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
