using MAP_PI.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Service.Pattern
{
    public class GestionService<T> : IGestionService<T> where T : class
    {

        #region Private Fields
        IUnitOfWork utwk;
        #endregion Private Fields

        #region Constructor
        public GestionService(IUnitOfWork utwk)
        {
            this.utwk = utwk;
        }
        #endregion Constructor

        public void Add(T entity)
        {
            utwk.getRepository<T>().Add(entity);
        }

        public void Commit()
        {
            try
            {
                utwk.Commit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            utwk.getRepository<T>().Delete(where);
        }

        public void Delete(T entity)
        {
            utwk.getRepository<T>().Delete(entity);
        }

        public void Dispose()
        {
            utwk.Dispose();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return utwk.getRepository<T>().Get(where);
        }

        public IEnumerable<T> GetAll()
        {
            return utwk.getRepository<T>().GetAll();
        }

        public T GetById(long id)
        {
            return utwk.getRepository<T>().GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            return utwk.getRepository<T>().GetMany(where, orderBy);
        }

        public void Update(T entity)
        {
            utwk.getRepository<T>().Update(entity);
        }

}
}
