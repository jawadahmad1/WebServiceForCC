using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Colonies
    {
        [Key]
        public int ColonyID { get; set; }
        public string ColonyName { get; set; }
        public int CityID { get; set; }
    }
}
