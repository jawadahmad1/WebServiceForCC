using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadiHelperWebService.Models
{
    public class Addresses
    {
        public int AddressID { get; set; }
        [Key]
        public int AddressesID { get; set; }
        public string AddressNumber { get; set; }
        public int StreetID { get; set; }
        public int BlockID { get; set; }
        public int ColonyID { get; set; }
        public int CityID { get; set; }
        public int ZipCodeID { get; set; }
        public int StateOrProvinceID { get; set; }
        public int CountryID { get; set; }
        public string Room { get; set; }
        public string Office { get; set; }
        public string Floor { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string AdditionalDetails { get; set; }
        //public string AddressDesc { get; set; }

    }
}
