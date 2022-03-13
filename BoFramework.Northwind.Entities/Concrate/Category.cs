using BoFramework.Core.Entities;

namespace BoFramework.Northwind.Entities.Concrate
{
    public class Category : IEntity
    {
        public virtual int CategoryId{ get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
    }
}
