﻿using System;
using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
    }
}
