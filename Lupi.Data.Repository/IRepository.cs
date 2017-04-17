using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lupi.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        TEntity GetByID(object id);
        void Save();
    }
}
