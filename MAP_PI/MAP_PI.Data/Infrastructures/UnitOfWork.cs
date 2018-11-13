﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Data.Infrastructures
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
            private MAP_PIContext dataContext;
            IDatabaseFactory dbFactory;
            public UnitOfWork(IDatabaseFactory dbFactory)
            {
                this.dbFactory = dbFactory;
                dataContext = dbFactory.DataContext;
            }

            public void Commit()
            {
                dataContext.SaveChanges();
            }

            public void Dispose()
            {
                dataContext.Dispose();
            }

            public IRepositoryBase<T> getRepository<T>() where T : class
            {
                IRepositoryBase<T> repo = new RepositoryBase<T>(dbFactory);
                return repo;
            }

        }

    }
