using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Contexts;
using Tourism.Models;
using Tourism.Repositories.Interfaces;

namespace Tourism.Repositories.Custom
{
    public class CountryRequirementRepository : ICountryRequirementRepository
    {
        private readonly MyDbContext myDbContext;

        public CountryRequirementRepository(MyDbContext context)
        {
            myDbContext = context;
        }
        public async Task<CountryRequirement> Create(CountryRequirement countryRequirement)
        {
            myDbContext.CountryRequirements.Add(countryRequirement);
            await myDbContext.SaveChangesAsync();
            return countryRequirement;
        }

        public async Task Delete(int id)
        {
            myDbContext.CountryRequirements.Remove(myDbContext.CountryRequirements.Find(id));
            await myDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CountryRequirement>> Get()
        {
            return await myDbContext.CountryRequirements.ToListAsync();
        }

        public async Task<CountryRequirement> Get(int id)
        {
            return await myDbContext.CountryRequirements.FindAsync(id);
        }

        public async Task Update(CountryRequirement countryRequirement)
        {
            myDbContext.Entry(countryRequirement).State = EntityState.Modified;
            await myDbContext.SaveChangesAsync();
        }
    }
}
