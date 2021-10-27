using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace winfentitygestcourse.DataAccess.DataObjects
{
    public partial class Course
    {
        public Course()
        {
            Inscription = new HashSet<Inscription>();
        }

        public int IdCourse { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public int Distance { get; set; }
        public DateTime HeureDepart { get; set; }

        public virtual ICollection<Inscription> Inscription { get; set; }
    }
}
