using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CAR;

namespace CAR.Inventory
{
    class UsersContext : DbContext
    {
        public UsersContext()
           : base("name=FDACARConnectionString")
       {
        }
        public DbSet<Users> Users { get; set; }
    }
}
