using System;
using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable
    {
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
    }
}
