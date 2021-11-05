using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class Country
    {
        public int id { get; set; }

        public string name { get; set; }
        public string capitalCity { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
        public int area { get; set; }
        public int population { get; set; }
    }
}
