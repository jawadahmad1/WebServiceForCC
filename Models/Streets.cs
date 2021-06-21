using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Streets
    {
        [Key]
        public int StreetID { get; set; }
        public string StreetName { get; set; }
        public int CityID { get; set; }
    }
}
