using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class StatesOrProvinces
    {
        [Key]
        public int StateOrProvinceID { get; set; }
        public string StateOrProvinceName { get; set; }
        public int CountryID { get; set; }
    }
}
