namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;

   // [Table("ElectronicsProduct")]
    public partial class ElectronicsProduct
    {
        [Key]
        public int ElectronicsID { get; set; }

        [StringLength(30)]
        public string ElectronicsName { get; set; }

        public int ProductID { get; set; }

        public virtual CommonProducts CommonProducts { get; set; }


        public ElectronicsProduct(int ElectronicsID, string ElectronicsName
          , int ProductID
            )
        {
            this.ElectronicsID = ElectronicsID;
            this.ElectronicsName = ElectronicsName;
            this.ProductID = ProductID;
        }
        public ElectronicsProduct()
        {

        }
    }


    //class ElectronicsProductsMap : EntityTypeConfiguration<ElectronicsProduct>
    //{
    //    public ElectronicsProductsMap()
    //    {
    //        this.HasOptional(x => x.CommonProducts)
    //            .WithOptionalPrincipal()
    //            .Map(x => x.MapKey("ElectronicsID"));
    //    }
    //}
}
