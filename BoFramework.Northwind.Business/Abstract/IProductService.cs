using BoFramework.Northwind.Entities.Concrate;
using System.Collections.Generic;

namespace BoFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
    }
}
