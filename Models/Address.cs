using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public Guid? VendorID { get; set; }
        public Guid? UserID { get; set; }
        
    }
}
