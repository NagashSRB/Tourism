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
    public class CountryRequirementsController : ControllerBase
    {
        private readonly ICountryRequirementRepository countryRequirementRepository;

        public CountryRequirementsController(ICountryRequirementRepository repository)
        {
            countryRequirementRepository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<CountryRequirement>> GetCountryRequirements()
        {
            return await countryRequirementRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CountryRequirement>> GetCountryRequirements(int id)
        {
            return await countryRequirementRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<CountryRequirement>> PostCountryRequirements([FromBody] CountryRequirement countryRequirement)
        {
            var newCountryRequirement = await countryRequirementRepository.Create(countryRequirement);
            return CreatedAtAction(nameof(GetCountryRequirements), new { id = newCountryRequirement.id }, newCountryRequirement);
        }

        [HttpPut]
        public async Task<ActionResult> PutCountryRequirements(int id, [FromBody] CountryRequirement countryRequirement)
        {
            if (id != countryRequirement.id)
            {
                return BadRequest();
            }

            await countryRequirementRepository.Update(countryRequirement);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCountryRequirements(int id)
        {
            var countryRequirement = await countryRequirementRepository.Get(id);
            if (countryRequirement == null)
            {
                return NotFound();
            }

            await countryRequirementRepository.Delete(id);

            return NoContent();
        }
    }
}
