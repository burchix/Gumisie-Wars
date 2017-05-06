using GummyBears.DTO.Models;
using System.Data.Entity;

namespace GummyBears.DAL
{
    public class GummyBearsContext : DbContext
    {
        public GummyBearsContext()
            : base("GummyBearsContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<UserDB> Users { get; set; }
        public DbSet<GameDB> Games { get; set; }
        public DbSet<MapDB> Maps { get; set; }
        public DbSet<SessionDB> Sessions { get; set; }
        public DbSet<StatsDB> Stats { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
