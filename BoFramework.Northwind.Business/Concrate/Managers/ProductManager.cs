using BoFramework.Northwind.Business.Abstract;
using BoFramework.Northwind.DataAccess.Abstract;
using BoFramework.Northwind.Entities.Concrate;
using System.Collections.Generic;

namespace BoFramework.Northwind.Business.Concrate.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
    }
}
