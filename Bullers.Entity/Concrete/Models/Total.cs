using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.Entity.Concrete.Models
{
    public class Total
    {
        public int ProductID { get; set; }

        public Guid ProductGuid { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage ="Please choose city")]
        public string City { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage ="Header is mandotary field")]
        public string ProductHeader { get; set; }

        [Required(ErrorMessage = "{0} is mandotary field")]
        public int Price { get; set; }

        [StringLength(400)]

        [Required(ErrorMessage = "{0} is mandotary field")]
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

        [Required(ErrorMessage = "Name is mandotary field")]
        public string OwnerName { get; set; }

        [StringLength(80)]

        [Required(ErrorMessage = "Email is mandotary field")]
        public string OwnerEmail { get; set; }

        [StringLength(11)]
        public string OwnerPhone { get; set; }

        [Required(ErrorMessage ="Please select category fields")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int ElectronicsID { get; set; }

        [StringLength(30)]
        public string ElectronicsName { get; set; }

        public int EstateID { get; set; }

        public string AdType { get; set; }
        
        public int Area { get; set; }

        public int totalRoom { get; set; }

        public int PersonelID { get; set; }

        [StringLength(10)]
        public string ProductSex { get; set; }

        [StringLength(30)]
        public string ProductName { get; set; }

        public int VehicleID { get; set; }

        [StringLength(70)]
        public string VehicleName { get; set; }

        [StringLength(30)]
        public string VehicleColor { get; set; }

        [StringLength(10)]
        public string VehicleMotor { get; set; }

        public int VehicleYear { get; set; }


        public int? OwnerID { get; set; }
    }
}
