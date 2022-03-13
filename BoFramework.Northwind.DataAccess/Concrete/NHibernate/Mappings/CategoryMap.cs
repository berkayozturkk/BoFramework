using BoFramework.Northwind.Entities.Concrate;
using FluentNHibernate.Mapping;

namespace BoFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {

        public CategoryMap()
        {
            Table(@"Categories");

            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryId");

            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.Description).Column("Description");
        }
    }
}
