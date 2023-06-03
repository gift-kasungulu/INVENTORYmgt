using .shared;
using Microsoft.EntityFrameworkCore;

namespace inventoryManagement.DbContextclass
{
    public class IDbcontext:DbContext
    {
        internal readonly object set;

        public IDbcontext(DbContextOptions<IDbcontext> options) : base(options)
        {   
        }

       public virtual DbSet<>

    }
}
