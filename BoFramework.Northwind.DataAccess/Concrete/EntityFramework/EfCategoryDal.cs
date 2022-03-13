using BoFramework.Core.DataAcces.EntityFramework;
using BoFramework.Northwind.DataAccess.Abstract;
using BoFramework.Northwind.Entities.Concrate;

namespace BoFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
