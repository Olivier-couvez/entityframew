using System;
using System.Collections.Generic;
using System.Text;
using winfentitygestcourse.DataAccess.DataObjects;
using System.Linq;

namespace winfentitygestcourse.Bll
{
    class BllCourses
    {
        public List<Course> getCourses()
        {
            gestioncoursesContext db = new gestioncoursesContext();
            List<Course> listearetourner = new List<Course>();
            var format = from f in db.Course select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }
    }
}
