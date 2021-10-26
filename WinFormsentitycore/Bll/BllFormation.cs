using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WinFormsentitycore.DataAcess.dataObjects;

namespace WinFormsentitycore.Bll
{
    class BllFormation
    {
        public bool AjouterFormation(string nom, string niveau, int nbStagiaires)
        {
            using formationsContext db = new formationsContext();
            Formation NouvelleFormation = new Formation()
            {
                Nom = nom,
                Niveau = niveau,
                NbStagiaire = nbStagiaires
            };
            db.Formation.Add(NouvelleFormation);
            db.SaveChanges();
            return true;
        }

        public bool supprimerFormation(int index)
        {
            using formationsContext db = new formationsContext();
            Formation SuppFormation = new Formation()
            {
                IdFormation = index
            };
            db.Formation.Remove(SuppFormation);
            db.SaveChanges();
            return true;
        }

        public bool ModificationFormation(int index, string nom, string niveau, int nbStagiaires)
        {
            bool etat = false;
            try
            {
                formationsContext db = new formationsContext();
                Formation MajFormation = new Formation()
                {
                    IdFormation = index,
                    Nom = nom,
                    Niveau = niveau,
                    NbStagiaire = nbStagiaires
                };
                db.Formation.Update(MajFormation);
                db.SaveChanges();
                etat = true;
            }
            catch
            {
                //erreur
            }
            return etat;
        }

        public List<Formation> getStagiaireFormation()
        {
            formationsContext db = new formationsContext();
            List<Formation> listearetourner = new List<Formation>();
            var format = from f in db.Formation select f;

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
