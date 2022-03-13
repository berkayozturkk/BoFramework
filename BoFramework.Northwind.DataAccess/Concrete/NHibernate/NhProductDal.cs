using BoFramework.Core.DataAcces.NHibernate;
using BoFramework.Northwind.DataAccess.Abstract;
using BoFramework.Northwind.Entities.Concrate;

namespace BoFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
