using CAR.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR
{

    public class CarContext : DbContext
    {
        public CarContext(): base(ConfigurationManager.ConnectionStrings["CAREntities"].ToString())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
          //  throw new UnintentionalCodeFirstException();
        }

        public DbSet<APO_PCO> Pcos { get; set; }
        public DbSet<ASSET> Assets { get; set; }
        public DbSet<CENTER> Centers { get; set; }
        public DbSet<USER> Users { get; set; }
    }
}
