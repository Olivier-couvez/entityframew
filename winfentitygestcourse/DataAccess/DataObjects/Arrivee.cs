using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Arrivee
    {
        public int IdArrivee { get; set; }
        public DateTime Temps { get; set; }
        public int InscriptionIdInscription { get; set; }

        public virtual Inscription InscriptionIdInscriptionNavigation { get; set; }
    }
}
