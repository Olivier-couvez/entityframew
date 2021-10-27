using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Transpondeur
    {
        public Transpondeur()
        {
            Inscription = new HashSet<Inscription>();
        }

        public int IdTranspondeur { get; set; }
        public bool Perdu { get; set; }

        public virtual ICollection<Inscription> Inscription { get; set; }
    }
}
