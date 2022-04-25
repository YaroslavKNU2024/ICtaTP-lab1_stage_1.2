using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class VirusGroup
    {
        public VirusGroup()
        {
            Viruses = new HashSet<Virus>();
        }

        public int IdGroup { get; set; }
        public string? GroupName { get; set; }
        public string? GroupInfo { get; set; }
        public DateTime? DateDiscovered { get; set; }
        public int IdClass { get; set; }

        public virtual ClassVirus IdClassNavigation { get; set; } = null!;
        public virtual ICollection<Virus> Viruses { get; set; }
    }
}
