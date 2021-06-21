using ShadiHelperWebService.Models;
using System.Collections.Generic;

namespace ShadiHelperWebService.Repository.ConcreteImplementation
{
    public interface ICategoryTypesRepository
    {
        IEnumerable<CategoryTypes> Get();
    }
}