using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class CategoryTypes
    {
        public int CategoryTypeParent { get; set; }
        public string CategoryTypeName { get; set; }
        [Key]
        public int CategoryTypeID { get; set; }
        public string CategoryTypeDesc { get; set; }
        public int SortAsc { get; set; }
    }
}
