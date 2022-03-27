namespace Bullers.Entity.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [StringLength(400)]
        public string Password { get; set; }

        [StringLength(50,MinimumLength =6,ErrorMessage ="Username should be between 6 and 50 characters")]
    
        public string Username { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Email is mandatory field")]
        [EmailAddress]
        public string UseEmail { get; set; }

        public virtual ICollection<UserFavorites> userFavorites { get; set; }
   
    }
}
