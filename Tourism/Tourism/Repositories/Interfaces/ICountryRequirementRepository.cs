using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.Repositories.Interfaces
{
    public interface ICountryRequirementRepository
    {
        Task<IEnumerable<CountryRequirement>> Get();
        Task<CountryRequirement> Get(int id);
        Task<CountryRequirement> Create(CountryRequirement countryRequirement);
        Task Update(CountryRequirement countryRequirement);
        Task Delete(int id);
    }
}
