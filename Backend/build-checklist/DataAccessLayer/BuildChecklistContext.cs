using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BuildChecklistContext : DbContext
    {
        public BuildChecklistContext() : base("BuildChecklistContext")
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }
        public DbSet<Users> Users{ get; set; }
        public DbSet<Conversions> Conversions { get; set; }
        public DbSet<SB> SB{ get; set; }
        public DbSet<ITL> ITL { get; set; }
        public DbSet<Live> Live { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
