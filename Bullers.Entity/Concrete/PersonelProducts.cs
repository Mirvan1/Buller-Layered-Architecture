namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;

    public partial class PersonelProducts
    {
        [Key]
        public int PersonelID { get; set; }

        [StringLength(10)]
        public string ProductSex { get; set; }

        [StringLength(30)]
        public string ProductName { get; set; }

        public int ProductID { get; set; }
       // public int CommonProducts_ProductID { get; set; }

       public virtual CommonProducts CommonProducts { get; set; }

        public PersonelProducts(int PersonelID,string ProductSex,string ProductName
          ,int ProductID
            )
        {
            this.PersonelID = PersonelID;
            this.ProductSex=ProductSex;
            this.ProductName = ProductName;
            this.ProductID = ProductID;
        }
        public PersonelProducts()
        {

        }


    }

    //class PersonelProductsMap : EntityTypeConfiguration<PersonelProducts>
    //{
    //    public PersonelProductsMap()
    //    {
    //        this.HasOptional(x => x.CommonProducts)
    //            .WithOptionalPrincipal()
    //            .Map(x => x.MapKey("PersonelID"));
    //    }
    //}
}
