using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using Dergi.Model.Repo;

namespace Dergi.Model.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<DergiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(DergiDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        public class DatabaseConfiguration
        {
            public static void StartMigration()
            {
                var configuration = new Configuration
                {
                    AutomaticMigrationsEnabled = true,
                    ContextType = typeof(DergiDbContext),
                    AutomaticMigrationDataLossAllowed = true,
                    TargetDatabase = new DbConnectionInfo("DergiDbContext"),//("Data Source=|DataDirectory|myblogdb.sdf", "System.Data.SqlServerCe.4.0"),

                };

                var migratorScriptingDecorator = new MigratorScriptingDecorator(new DbMigrator(configuration));

                IEnumerable<string> pendingMigrations = migratorScriptingDecorator.GetPendingMigrations();

                var dbMigrator = new DbMigrator(configuration);

                foreach (var pendingMigration in pendingMigrations)
                {
                    dbMigrator.Update(pendingMigration);
                }

                //var migratorScriptingDecorator = new MigratorScriptingDecorator(dbMigrator);

                //IEnumerable<string> databaseMigrations = migratorScriptingDecorator.GetDatabaseMigrations();

                //IEnumerable<string> localMigrations = migratorScriptingDecorator.GetLocalMigrations();

                //IEnumerable<string> pendingMigrations = migratorScriptingDecorator.GetPendingMigrations();

                //var script = migratorScriptingDecorator.ScriptUpdate(sourceMigration: null, targetMigration:null);
            }
        }

    }
}
