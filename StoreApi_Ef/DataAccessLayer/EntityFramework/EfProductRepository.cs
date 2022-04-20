using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory(int categoryId)
        {
            using var c = new Context();
           
            return c.Products.Where(x => x.CategoryId == categoryId ).ToList();
        }
    }
}
