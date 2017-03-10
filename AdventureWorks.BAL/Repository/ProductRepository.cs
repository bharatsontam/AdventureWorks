using AdventureWorks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BAL.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private AdventureWorksEntities context;
        public ProductRepository()
        {
            context = new AdventureWorksEntities();
        }
        public IEnumerable<Product> GetAll
        {
            get
            {
                return context.Products.ToList();
            }
        }

        public void DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Product Edit(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetEntityById(int id)
        {
            return context.Products.Where(x => x.ProductID == id).FirstOrDefault();
        }

        public Product Insert(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
