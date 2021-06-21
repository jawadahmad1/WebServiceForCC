using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceForCC.Models
{
    public class Categories
    {
        
        public Guid VendorID { get; set; }
        [Key]
        public int CategoryID { get; set; }
        public int CategoryTypeID { get; set; }
        public string CategoryDesc { get; set; }
        
    }
}
