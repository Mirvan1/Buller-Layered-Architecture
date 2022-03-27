namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;

    //[Table("VehicleProduct")]
    public partial class VehicleProduct
    {
        [Key]
        public int VehicleID { get; set; }

        [StringLength(70)]
        public string VehicleName { get; set; }

        [StringLength(30)]
        public string VehicleColor { get; set; }

        [StringLength(10)]
        public string VehicleMotor { get; set; }

        public int VehicleYear { get; set; }

        public int ProductID { get; set; }

        public virtual CommonProducts CommonProducts { get; set; }

        public VehicleProduct(int VehicleID,string VehicleName,string VehicleColor,string VehicleMotor,int VehicleYear
            ,int ProductID
            )
        {
            this.VehicleID = VehicleID;
            this.VehicleName = VehicleName;
            this.VehicleColor = VehicleColor;
            this.VehicleMotor = VehicleMotor;
            this.VehicleYear = VehicleYear;
           this.ProductID = ProductID;
        }
        public VehicleProduct()
        {

        }
    }


    //class VehicleProductsMap : EntityTypeConfiguration<VehicleProduct>
    //{
    //    public VehicleProductsMap()
    //    {
    //        this.HasOptional(x => x.CommonProducts)
    //            .WithOptionalPrincipal()
    //            .Map(x => x.MapKey("VehicleID"));
    //    }
    //}
}
