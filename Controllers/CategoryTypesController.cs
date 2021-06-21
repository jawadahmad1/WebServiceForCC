using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShadiHelperWebService.Models;
using ShadiHelperWebService.Repository.ConcreteImplementation;
using WebServiceForCC.Models;

namespace ShadiHelperWebService.Controllers
{
    [Route("api/categorytypes")]
    [ApiController]
    public class CategoryTypesController : ControllerBase
    {
        private readonly ICategoryTypesRepository _categoryTypesRepository;

        public CategoryTypesController(ICategoryTypesRepository categoryTypesRepository)
        {
            _categoryTypesRepository = categoryTypesRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryTypesRepository.Get());
        }

    }
}
