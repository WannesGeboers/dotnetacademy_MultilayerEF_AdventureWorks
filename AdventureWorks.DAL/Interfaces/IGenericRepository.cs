﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL.Interfaces
{
    public interface IGenericRepository<TEntity>:IDisposable
    {
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();       
    }
}