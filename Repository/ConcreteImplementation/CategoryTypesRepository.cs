using Microsoft.EntityFrameworkCore;
using ShadiHelperWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceForCC.Models;

namespace ShadiHelperWebService.Repository.ConcreteImplementation
{
    public class CategoryTypesRepository : ICategoryTypesRepository
    {
        private readonly VendorDataContext _vendorDataContext;
        public CategoryTypesRepository(VendorDataContext vendorDataContext)
        {
            _vendorDataContext = vendorDataContext;
        }
        public IEnumerable<CategoryTypes> Get()
        {
            return _vendorDataContext.CategoryTypes.OrderBy(x => x.CategoryTypeID);
        }
       
    }
}
