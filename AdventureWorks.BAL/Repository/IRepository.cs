using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BAL.Repository
{
    public interface IRepository<T>
    {
        T Insert(T entity);
        T Edit(T entity);
        IEnumerable<T> GetAll { get; }
        T GetEntityById(int id);
        void DeleteEntity(int id);
    }
}
