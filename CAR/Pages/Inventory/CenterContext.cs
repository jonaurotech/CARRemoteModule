using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CAR;

namespace CAR.Inventory
{
    class CenterContext : DbContext
    {
        public CenterContext()
           : base("name=FDACARConnectionString")
       {
        }
        public DbSet<Center>   Centers { get; set; }
    }
}
