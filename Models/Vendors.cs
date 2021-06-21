using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceForCC.Models
{
    public class Vendors
    {
        [Key]
        public Guid VendorID { get; set; }
        public string CompanyName { get; set; }
        public bool Featured { get; set; }
        public string CompanyDesc { get; set; }
        public int InternalScore { get; set; }
        public int Suspicious { get; set; }


    }
}
