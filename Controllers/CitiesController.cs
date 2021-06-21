using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShadiHelperWebService.Models;
using ShadiHelperWebService.Repository.ConcreteImplementation;
using WebServiceForCC.Models;

namespace ShadiHelperWebService.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesRepository _citiesRepository;
        public CitiesController(ICitiesRepository citiesRepository,VendorDataContext vendorDataContext)
        {
            _citiesRepository = citiesRepository;
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_citiesRepository.Get());
        }
       
    }
}
