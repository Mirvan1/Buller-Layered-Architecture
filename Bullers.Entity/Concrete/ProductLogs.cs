using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.Entity.Concrete
{
    public class ProductLogs
    {
        [Key]
        public int LogID { get; set; }

        [StringLength(80)]
        public string ActionName{get;set;}
        public int ProductID { get; set; }
        public DateTime DateTime { get; set; }
        [StringLength(150)]
        public string Info { get; set; }

        public string ViewerMail { get; set; }


    }
}
