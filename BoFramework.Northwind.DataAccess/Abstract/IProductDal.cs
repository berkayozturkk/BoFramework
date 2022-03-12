using BoFramework.Core.DataAcces;
using BoFramework.Northwind.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {

    }
}
