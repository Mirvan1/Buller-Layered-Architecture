using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.Entity.Concrete.Models
{
   public  class TotalVehicle
    {
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

        public int CategoryID { get; set; }
        public int? OwnerID { get; set; }
        public virtual Category Category { get; set; }
        public int VehicleID { get; set; }

        [StringLength(70)]
        public string VehicleName { get; set; }

        [StringLength(30)]
        public string VehicleColor { get; set; }

        [StringLength(10)]
        public string VehicleMotor { get; set; }

        public int VehicleYear { get; set; }


        public virtual CommonProducts CommonProducts { get; set; }

        public TotalVehicle(int ProductID, Guid ProductGuid, string City, string ProductHeader,int Price, string Description, string OwnerName, string OwnerEmail,
            string OwnerPhone,int? OwnerID, int CategoryID,int VehicleID,string VehicleName,string VehicleColor,string VehicleMotor,int VehicleYear)
        {

            this.ProductID = ProductID;
            this.ProductGuid = ProductGuid;
            this.City = City;
            this.ProductHeader = ProductHeader;
            this.Price = Price;
            this.Description = Description;
            this.OwnerName = this.OwnerName;
            this.OwnerEmail = OwnerEmail;
            this.OwnerPhone = OwnerPhone;
            this.VehicleID = VehicleID;
            this.VehicleName = VehicleName;
            this.VehicleColor = VehicleColor;
            this.VehicleMotor = VehicleMotor;
            this.VehicleYear = VehicleYear;
            this.OwnerID = OwnerID;
        }
    }
}
