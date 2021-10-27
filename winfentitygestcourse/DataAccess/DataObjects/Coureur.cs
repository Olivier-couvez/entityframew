using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Coureur
    {
        public Coureur()
        {
            Inscription = new HashSet<Inscription>();
        }

        public int IdCoureur { get; set; }
        public int ClubIdClub { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public int CategorieIdCategorie { get; set; }

        public virtual Categorie CategorieIdCategorieNavigation { get; set; }
        public virtual Club ClubIdClubNavigation { get; set; }
        public virtual ICollection<Inscription> Inscription { get; set; }
    }
}
