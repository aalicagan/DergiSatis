using System.Data.Entity;

namespace Dergi.Model.Repo
{
    public class DergiDbContext : DbContext
    {
        public DbSet<Bolge> Bolges { get; set; }
        public DbSet<BirimTur> BirimTurs { get; set; }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Dergi> Dergis { get; set; }
        public DbSet<AboneType> AboneTypes { get; set; }
        public DbSet<Abone> Abones { get; set; }
        public DbSet<AboneDergi> AboneDergis { get; set; }
        public DbSet<AboneHesap> AboneHesaps { get; set; }
        

    }
}
