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
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public Category GetSingleCategoryByProductAsync(int productId)
        {
            using var c = new Context();
            return c.Categories.Single(c => c.Products.Any(p => p.Id == productId));
        }
    }
}
