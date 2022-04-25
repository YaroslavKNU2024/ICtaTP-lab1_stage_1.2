using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Country
    {
        public Country()
        {
            TableCountries = new HashSet<TableCountry>();
        }

        public int IdCountry { get; set; }
        public string? NameCountry { get; set; }

        public virtual ICollection<TableCountry> TableCountries { get; set; }
    }
}
