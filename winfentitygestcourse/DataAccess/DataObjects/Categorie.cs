using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Categorie
    {
        public Categorie()
        {
            Coureur = new HashSet<Coureur>();
        }

        public int IdCategorie { get; set; }
        public string Nom { get; set; }
        public int AgeMini { get; set; }
        public int AgeMaxi { get; set; }
        public int DistanceMax { get; set; }

        public virtual ICollection<Coureur> Coureur { get; set; }
    }
}
