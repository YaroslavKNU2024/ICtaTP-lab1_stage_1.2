using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Symptom
    {
        public Symptom()
        {
            IdVariants = new HashSet<Variant>();
        }

        public int IdSymptoms { get; set; }
        public string? NameSymptom { get; set; }

        public virtual ICollection<Variant> IdVariants { get; set; }
    }
}
