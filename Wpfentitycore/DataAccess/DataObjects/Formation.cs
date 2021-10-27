using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Wpfentitycore.DataAccess.DataObjects
{
    public partial class Formation
    {
        public Formation()
        {
            Stagiaire = new HashSet<Stagiaire>();
        }

        public int IdFormation { get; set; }
        public string Nom { get; set; }
        public string Niveau { get; set; }
        public int NbStagiaire { get; set; }

        public virtual ICollection<Stagiaire> Stagiaire { get; set; }
    }
}
