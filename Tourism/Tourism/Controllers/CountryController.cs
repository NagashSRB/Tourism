using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;
using Tourism.Repositories.Interfaces;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository countryRepository;

        public CountryController(ICountryRepository repository)
        {
            countryRepository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Country>> GetCountry()
        {
            return await countryRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            return await countryRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Country>> PostCountryRequirements([FromBody] Country country)
        {
            var newCountry = await countryRepository.Create(country);
            return CreatedAtAction(nameof(GetCountry), new { id = newCountry.id }, newCountry);
        }

        [HttpPut]
        public async Task<ActionResult> PutCountry(int id, [FromBody] Country country)
        {
            if (id != country.id)
            {
                return BadRequest();
            }

            await countryRepository.Update(country);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCountryRequirements(int id)
        {
            var countryRequirement = await countryRepository.Get(id);
            if (countryRequirement == null)
            {
                return NotFound();
            }

            await countryRepository.Delete(id);

            return NoContent();
        }
    }
}
