using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Cities
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateOrProvinceID { get; set; }
    }
}
