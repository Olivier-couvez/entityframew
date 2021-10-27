using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Inscription
    {
        public Inscription()
        {
            Arrivee = new HashSet<Arrivee>();
        }

        public int IdInscription { get; set; }
        public int NumDossard { get; set; }
        public int CoureurIdCoureur { get; set; }
        public int TranspondeurIdTranspondeur { get; set; }
        public int CourseIdCourse { get; set; }

        public virtual Coureur CoureurIdCoureurNavigation { get; set; }
        public virtual Course CourseIdCourseNavigation { get; set; }
        public virtual Transpondeur TranspondeurIdTranspondeurNavigation { get; set; }
        public virtual ICollection<Arrivee> Arrivee { get; set; }
    }
}
