using BoFramework.Core.DataAcces.EntityFramework;
using BoFramework.Northwind.DataAccess.Abstract;
using BoFramework.Northwind.Entities.ComplexTypes;
using BoFramework.Northwind.Entities.Concrate;
using System.Collections.Generic;
using System.Linq;

namespace BoFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                             };
             return result.ToList();
            } 
        }
    }
}
