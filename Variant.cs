using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Variant
    {
        public Variant()
        {
            TableCountries = new HashSet<TableCountry>();
            IdSymptoms = new HashSet<Symptom>();
        }

        public int IdVariant { get; set; }
        public string? VariantName { get; set; }
        public string? VariantOrigin { get; set; }
        public int? IdVirus { get; set; }
        public DateTime? DateDiscovered { get; set; }

        public virtual Virus? IdVirusNavigation { get; set; }
        public virtual ICollection<TableCountry> TableCountries { get; set; }

        public virtual ICollection<Symptom> IdSymptoms { get; set; }
    }
}
