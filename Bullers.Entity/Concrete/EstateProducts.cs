namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;

    public partial class EstateProducts
    {
        [Key]
        public int EstateID { get; set; }


        public string AdType { get; set; }

        public int Area { get; set; }

        public int totalRoom { get; set; }

      public int ProductID { get; set; }

        public virtual CommonProducts CommonProducts { get; set; }

        public EstateProducts(int EstateID, string AdType, int Area, int totalRoom
           , int ProductID
            )
        {
            this.EstateID = EstateID;
            this.AdType = AdType;
            this.Area = Area;
            this.totalRoom = totalRoom;
           this.ProductID = ProductID;
        }
        public EstateProducts()
        {

        }
    }

    //class EstateProductsMap : EntityTypeConfiguration<EstateProducts>
    //{
    //    public EstateProductsMap()
    //    {
    //        this.HasOptional(x => x.CommonProducts)
    //            .WithOptionalPrincipal()
    //            .Map(x => x.MapKey("EstateID"));
    //    }
    //}
}
