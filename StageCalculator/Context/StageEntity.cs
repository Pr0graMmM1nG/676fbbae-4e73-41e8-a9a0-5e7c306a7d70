using System.Data.Entity;
using StageCalculator.Models;
using SQLite.CodeFirst;

namespace StageCalculator.Context
{
    class StageEntity: DbContext
    {
        public StageEntity() : base("SQLiteContext")
        {
            

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<StageEntity>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
             

        }


        public DbSet<Person> Persons { get; set; }
        public DbSet<Buletin> Buletins { get; set; }
        public DbSet<Company> Companys{ get; set; }
        public DbSet<Stage> Stages { get; set; }

    }
}
