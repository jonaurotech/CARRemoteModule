using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CAR;


namespace CAR.Inventory
{
    class AccountablePropertyOfficerContext : DbContext
    {
        public AccountablePropertyOfficerContext()
           : base("name=FDACARConnectionString")
       {
        }
        public DbSet<AccountablePropertyOfficer> AccountablePropertyOfficers { get; set; }
    }
}
