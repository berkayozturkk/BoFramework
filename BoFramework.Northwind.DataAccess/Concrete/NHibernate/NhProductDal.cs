using BoFramework.Core.DataAcces.NHibernate;
using BoFramework.Northwind.DataAccess.Abstract;
using BoFramework.Northwind.Entities.ComplexTypes;
using BoFramework.Northwind.Entities.Concrate;
using System.Collections.Generic;
using System.Linq;

namespace BoFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;

        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>()
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
