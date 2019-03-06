using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace DAL
{
    public partial class DBContext : DbContext
    {
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSubscription> UserSubscriptions { get; set; }

        public DBContext() : base("name=DBContext")
            //base("data source=.;initial catalog=DemoDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("dbo.User");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
