using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Data.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MAP_PIContext dataContext;
        public MAP_PIContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new MAP_PIContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }

    }
}
