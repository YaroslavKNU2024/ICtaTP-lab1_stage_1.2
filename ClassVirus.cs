using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class ClassVirus
    {
        public ClassVirus()
        {
            VirusGroups = new HashSet<VirusGroup>();
        }

        public int IdClass { get; set; }
        public string? InfoVirusClass { get; set; }
        public string? TypeClass { get; set; }

        public virtual ICollection<VirusGroup> VirusGroups { get; set; }
    }
}
