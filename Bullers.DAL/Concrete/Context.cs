using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Bullers.Entity.Concrete;

namespace Bullers.DAL
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());

        }

        //public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CommonProducts> CommonProducts { get; set; }
        
        public virtual DbSet<EstateProducts> EstateProducts { get; set; }
        public virtual DbSet<PersonelProducts> PersonelProducts { get; set; }
        public virtual DbSet<ElectronicsProduct> ElectronicsProduct { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VehicleProduct> VehicleProduct { get; set; }
        public virtual DbSet<UserFavorites> UserFavorites { get; set; }

        public virtual DbSet<ProductLogs> ProductLogs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CommonProducts)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

          


        }
    }
}
