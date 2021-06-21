using Microsoft.EntityFrameworkCore;
using ShadiHelperWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceForCC.Models;

namespace ShadiHelperWebService.Repository.ConcreteImplementation
{
    public class CitiesRepository : ICitiesRepository
    {
        private readonly VendorDataContext _vendorDataContext;
        public CitiesRepository(VendorDataContext vendorDataContext)
        {
            _vendorDataContext = vendorDataContext;
        }
        public IEnumerable<Cities> Get()

        {
            return _vendorDataContext.Cities.OrderBy(x => x.CityID);
        }
        
    }
}
