using Microsoft.Data.Entity;
using System.Data.SqlClient;

namespace MigrationDownRepro
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\v11.0",
                MultipleActiveResultSets = true,
                InitialCatalog = "MigrationDownRepro",
                IntegratedSecurity = true,
                ConnectTimeout = 30
            }.ConnectionString);
        }

        public DbSet<MyData> MyData { get; set; }
    }
}