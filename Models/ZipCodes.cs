using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class ZipCodes
    {
        [Key]
        public int ZipCodeID { get; set; }
        public string ZipCode { get; set; }
        public int CityID { get; set; }
    }
}
