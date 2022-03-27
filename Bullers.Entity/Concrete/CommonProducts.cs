namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;

    public partial class CommonProducts
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public CommonProducts()
        //{
        //    ElectronicsProduct = new HashSet<ElectronicsProduct>();
        //    EstateProducts = new HashSet<EstateProducts>();
        //    PersonelProducts = new HashSet<PersonelProducts>();
        //    VehicleProduct = new HashSet<VehicleProduct>();
        //}



        [Key]
        public int ProductID { get; set; }

        public Guid ProductGuid { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(40)]
        public string ProductHeader { get; set; }

        public int Price { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [StringLength(400)]
        public string Image1 { get; set; }
        [StringLength(400)]
        public string Image2 { get; set; }
        [StringLength(400)]
        public string Image3 { get; set; }
        [StringLength(400)]
        public string Image4 { get; set; }
        [StringLength(400)]
        public string Image5 { get; set; }
        [StringLength(400)]
        public string Image6 { get; set; }

        [StringLength(20)]
        public string OwnerName { get; set; }

        [StringLength(80)]
        public string OwnerEmail { get; set; }

        [StringLength(11)]
        public string OwnerPhone { get; set; }

        public int? OwnerID { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

       
        

        public virtual ICollection<UserFavorites> UserFavorites{get;set;}

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ElectronicsProduct> ElectronicsProduct { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EstateProducts> EstateProducts { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonelProducts> PersonelProducts { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<VehicleProduct> VehicleProduct { get; set; }

        public virtual ICollection<PersonelProducts> PersonelProducts { get; set; }
        public virtual ICollection<ElectronicsProduct> ElectronicsProduct { get; set; }
        public virtual ICollection<EstateProducts> EstateProducts { get; set; }
        public virtual ICollection<VehicleProduct> VehicleProduct { get; set; }
        public CommonProducts(int ProductID, Guid ProductGuid, string City,string ProductHeader, int Price, string Description ,string OwnerName, string OwnerEmail,
            string OwnerPhone, int? OwnerID, int CategoryID,string Image1,string Image2,string Image3,string Image4,string Image5,string Image6)
        {
            this.ProductID = ProductID;
            this.ProductGuid = ProductGuid;
            this.City = City;
            this.ProductHeader = ProductHeader;
            this.Price = Price;
            this.Description = Description;
            this.OwnerName = OwnerName;
            this.OwnerEmail = OwnerEmail;
            this.OwnerPhone = OwnerPhone;
            this.CategoryID = CategoryID;
            this.Image1 = Image1;
            this.Image2 = Image2;
            this.Image3 = Image3;
            this.Image4 = Image4;
            this.Image5 = Image5;
            this.Image6 = Image6;
            this.OwnerID = OwnerID;

        }
        public CommonProducts()
        {

        }
    }
    //class CommonProductsMap : EntityTypeConfiguration<CommonProducts>
    //{
    //    public CommonProductsMap()
    //    {
    //        this.HasOptional(x => x.PersonelProducts)
    //            .WithOptionalPrincipal()
    //            .Map(x => x.MapKey("ProductID"));

    //        this.HasOptional(x => x.ElectronicsProduct)
    //           .WithOptionalPrincipal()
    //           .Map(x => x.MapKey("ProductID"));

    //        this.HasOptional(x => x.EstateProducts)
    //          .WithOptionalPrincipal()
    //          .Map(x => x.MapKey("ProductID"));

    //        this.HasOptional(x => x.VehicleProduct)
    //          .WithOptionalPrincipal()
    //          .Map(x => x.MapKey("ProductID"));
    //    }
    //}
}
