using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Blocks
    {
        [Key]
        public int BlockID { get; set; }
        public string BlockName { get; set; }
        public int ColonyID { get; set; }
    }
}
