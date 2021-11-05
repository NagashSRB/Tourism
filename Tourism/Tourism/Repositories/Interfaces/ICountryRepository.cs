using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.Repositories.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> Get();
        Task<Country> Get(int id);
        Task<Country> Create(Country country);
        Task Update(Country country);
        Task Delete(int id);
    }
}
