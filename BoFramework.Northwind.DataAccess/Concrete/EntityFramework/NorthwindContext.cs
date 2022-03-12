using BoFramework.Northwind.Entities.Concrate;
using System.Data.Entity;

namespace BoFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
            //Prevents database creation
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
