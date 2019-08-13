﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL
{
    public class UnitOfWork : IDisposable
    {
        private AVContext context = new AVContext();
        private GenericRepository<Game> gameRepository;
        public GenericRepository<Game> GameRepository
        {
            get
            {
                return this.gameRepository ?? new GenericRepository<Game>(context);
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
