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

            //modelBuilder.Entity<CommonProducts>()
            //    .Property(e => e.City)
            //    .IsUnicode(false); 

            //modelBuilder.Entity<CommonProducts>()
            //    .Property(e => e.Description)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .Property(e => e.OwnerName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .Property(e => e.OwnerEmail)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .Property(e => e.OwnerPhone)
            //    .IsUnicode(false);













            //modelBuilder.Entity<CommonProducts>()
            //    .HasRequired(x => x.PersonelProducts)
            //    .WithRequiredPrincipal(s => s.CommonProducts);

            //modelBuilder.Entity<CommonProducts>()
            //   .HasRequired(x => x.ElectronicsProduct)
            //   .WithRequiredPrincipal(s => s.CommonProducts);


            //modelBuilder.Entity<CommonProducts>()
            //   .HasRequired(x => x.EstateProducts)
            //   .WithRequiredPrincipal(s => s.CommonProducts);


            //modelBuilder.Entity<CommonProducts>()
            //   .HasRequired(x => x.VehicleProduct)
            //   .WithRequiredPrincipal(s => s.CommonProducts);










            //modelBuilder.Entity<CommonProducts>()
            //    .HasMany(e => e.ElectronicsProduct)
            //    .WithRequired(e => e.CommonProducts)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .HasMany(e => e.EstateProducts)
            //    .WithRequired(e => e.CommonProducts)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .HasMany(e => e.PersonelProducts)
            //    .WithRequired(e => e.CommonProducts)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CommonProducts>()
            //    .HasMany(e => e.VehicleProduct)
            //    .WithRequired(e => e.CommonProducts)
            //    .WillCascadeOnDelete(false);













            //modelBuilder.Entity<CommonProducts>()
            //   .HasOptional(o => o.PersonelProducts)
            //   .WithOptionalPrincipal(o => o.CommonProducts)
            //   ;
            ////.Map(c=>c.MapKey("ProductID"));


            //modelBuilder.Entity<CommonProducts>()
            //   .HasOptional(o => o.ElectronicsProduct)
            //   .WithOptionalPrincipal(o => o.CommonProducts);
            //// .Map(c => c.MapKey("ProductID"));


            //modelBuilder.Entity<CommonProducts>()
            //   .HasOptional(o => o.EstateProducts)
            //   .WithOptionalPrincipal(o => o.CommonProducts);
            //   //.Map(c => c.MapKey("ProductID"));


            //modelBuilder.Entity<CommonProducts>()
            //   .HasOptional(o => o.VehicleProduct)
            //   .WithOptionalPrincipal(o => o.CommonProducts);
            // //  .Map(c => c.MapKey("ProductID"));


        }
    }
}
