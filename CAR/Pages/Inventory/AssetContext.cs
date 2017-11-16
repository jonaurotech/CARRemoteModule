using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CAR;

namespace CAR.Inventory
{
    class AssetContext : DbContext
    {
        public AssetContext()
           : base("name=FDACARConnectionString")
       {
        }
        public DbSet<Asset> Assets { get; set; }
    }
}

