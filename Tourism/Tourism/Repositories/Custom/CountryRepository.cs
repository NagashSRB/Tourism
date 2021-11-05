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
    public class CountryRepository : ICountryRepository
    {
        private readonly MyDbContext myDbContext;

        public CountryRepository(MyDbContext context)
        {
            myDbContext = context;
        }
        public async Task<Country> Create(Country country)
        {
            myDbContext.Country.Add(country);
            await myDbContext.SaveChangesAsync();
            return country;
        }

        public async Task Delete(int id)
        {
            myDbContext.Country.Remove(myDbContext.Country.Find(id));
            await myDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Country>> Get()
        {
            return await myDbContext.Country.ToListAsync();
        }

        public async Task<Country> Get(int id)
        {
            return await myDbContext.Country.FindAsync(id);
        }

        public async Task Update(Country country)
        {
            myDbContext.Entry(country).State = EntityState.Modified;
            await myDbContext.SaveChangesAsync();
        }
    }
}
