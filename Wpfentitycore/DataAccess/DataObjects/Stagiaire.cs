using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Wpfentitycore.DataAccess.DataObjects
{
    public partial class Stagiaire
    {
        public int IdStagiaire { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public int IdFormation { get; set; }

        public virtual Formation IdFormationNavigation { get; set; }
    }
}
