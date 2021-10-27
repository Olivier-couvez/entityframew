using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Club
    {
        public Club()
        {
            Coureur = new HashSet<Coureur>();
        }

        public int IdClub { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Coureur> Coureur { get; set; }
    }
}
