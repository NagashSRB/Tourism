using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class CountryRequirement
    {
        public int id { get; set; }

        public string countryName { get; set; }

        public bool visa { get; set; }

        public bool greenCard { get; set; }

        public bool pcrTest { get; set; }

        public bool antigenTest { get; set; }

        public bool vaccinated { get; set; }
    }
}
