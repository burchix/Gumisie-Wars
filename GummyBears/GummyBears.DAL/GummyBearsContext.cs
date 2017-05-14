using GummyBears.DTO.Models;
using Npgsql;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;

namespace GummyBears.DAL
{
    //[DbConfigurationType(typeof(ElephantSqlDbConfiguration))]
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

    #region Utils

    internal sealed class ElephantSqlDbConfiguration : DbConfiguration
    {
        private const string ManifestToken = @"9.4.1";
        public ElephantSqlDbConfiguration()
        {
            this.AddDependencyResolver(new SingletonDependencyResolver<IManifestTokenResolver>(new ManifestTokenService()));
        }
        private sealed class ManifestTokenService : IManifestTokenResolver
        {
            private static readonly IManifestTokenResolver DefaultManifestTokenResolver
              = new DefaultManifestTokenResolver();
            public string ResolveManifestToken(DbConnection connection)
            {
                if (connection is NpgsqlConnection)
                {
                    return ManifestToken;
                }
                return DefaultManifestTokenResolver.ResolveManifestToken(connection);
            }
        }
    }

    #endregion
}
