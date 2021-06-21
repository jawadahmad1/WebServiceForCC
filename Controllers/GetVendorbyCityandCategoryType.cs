using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceForCC.Models;

namespace ShadiHelperWebService.Controllers
{
    [Route("api/gvbcityandcategorytypes")]
    [ApiController]
    public class GetVendorbyCityandCategoryType : ControllerBase
    {
        private readonly VendorDataContext context;
        public GetVendorbyCityandCategoryType(VendorDataContext context)
        {
            this.context = context;
        }
        
        // Get Vendor by AddressItemID
        [HttpGet]
        public IQueryable<object> Getcity(int inputcity, int inputcategoryType)
        {

            return from vendors in context.Vendors

                   
                   join address in context.Address
                   on vendors.VendorID equals address.VendorID

                   join addresses in context.Addresses
                   on address.AddressID equals addresses.AddressID

                   join city in context.Cities
                   on addresses.CityID equals city.CityID

                   join category in context.Categories
                   on vendors.VendorID equals category.VendorID

                   join categorytype in context.CategoryTypes
                   on category.CategoryTypeID equals categorytype.CategoryTypeID

                   join blocks in context.Blocks
                   on addresses.BlockID equals blocks.BlockID

                   join colony in context.Colonies
                   on addresses.ColonyID equals colony.ColonyID

                   join country in context.Countries
                   on addresses.CountryID equals country.CountryID

                   join stateorprovince in context.StatesOrProvinces
                   on addresses.StateOrProvinceID equals stateorprovince.StateOrProvinceID

                   join street in context.Streets
                   on addresses.StreetID equals street.StreetID

                   join zipcode in context.ZipCodes
                   on addresses.ZipCodeID equals zipcode.ZipCodeID
                   
                   where (city.CityID == inputcity & categorytype.CategoryTypeID== inputcategoryType)
                   orderby vendors.CompanyName
                   select new
                   {
                       vendors.VendorID,
                       vendors.CompanyName,
                       vendors.CompanyDesc
                   };

        }

    }
}
