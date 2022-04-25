using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class Virus
    {
        public Virus()
        {
            Variants = new HashSet<Variant>();
        }

        public int IdVirus { get; set; }
        public string? VirusName { get; set; }
        public DateTime? DateDiscovered { get; set; }
        public int IdVirusGroup { get; set; }

        public virtual VirusGroup IdVirusGroupNavigation { get; set; } = null!;
        public virtual ICollection<Variant> Variants { get; set; }
    }
}
