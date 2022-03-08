using BoFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoFramework.Core.DataAcces.EntityFramework
{
    public class EfQuerableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;

        public EfQuerableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;

        public virtual IDbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>());  }
        }
    }
}
