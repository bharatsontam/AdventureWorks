using AdventureWorks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AdventureWorks.BAL.Repository
{
    //public class Repository<T> : IRepository<T> where T: class, IEntity
    //{
    //    private AdventureWorksEntities context;
    //    public Repository()
    //    {
    //        this.context = new AdventureWorksEntities();
    //    }
    //    public IEnumerable<T> GetAll
    //    {
    //        get
    //        {
    //            context.Set<T>().ToList();
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public void DeleteEntity(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public T Edit(T entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public T GetEntityById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public T Insert(T entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
