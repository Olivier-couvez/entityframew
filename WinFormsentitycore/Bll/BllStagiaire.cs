using System;
using System.Collections.Generic;
using System.Text;
using WinFormsentitycore.DataAcess.dataObjects;
using System.Linq;

namespace WinFormsentitycore.Bll
{
    class BllStagiaire
    {
        public bool AjouterStagiaire(string nom, string prenom, int age, int idForm)
        {
            using formationsContext db = new formationsContext();
            Stagiaire NouveauStagiaire = new Stagiaire()
            {
                Nom = nom,
                Prenom = prenom,
                Age = age,
                IdFormation = idForm
            };
            db.Stagiaire.Add(NouveauStagiaire);
            db.SaveChanges();
            return true;
        }

        public bool supprimerStagiaire(int index)
        {
            using formationsContext db = new formationsContext();
            Stagiaire SuppStagiaire = new Stagiaire()
            {
                IdStagiaire = index
            };
            db.Stagiaire.Remove(SuppStagiaire);
            db.SaveChanges();
            return true;
        }

        public bool modificationStagiaire(int index, string nom, string prenom, int age, int idform)
        {
            bool etat = false;
            try
            {
                formationsContext db = new formationsContext();
                Stagiaire MajStagiaire = new Stagiaire()
                {
                    IdStagiaire = index,
                    Nom = nom,
                    Prenom = prenom,
                    Age = age,
                    IdFormation = idform
                };
                db.Stagiaire.Update(MajStagiaire);
                db.SaveChanges();
                etat = true;
            }
            catch
            {
                //erreur
            }
            return etat;
        }

        public List<Stagiaire> getStagiaireNom(string fNom)
        {
            formationsContext db = new formationsContext();
            List<Stagiaire> listearetourner = new List<Stagiaire>();
            var format = from f in db.Stagiaire
                         where f.Nom == fNom
                         select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }

        public List<Stagiaire> getStagiairePrenom(string fNom)
        {
            formationsContext db = new formationsContext();
            List<Stagiaire> listearetourner = new List<Stagiaire>();
            var format = from f in db.Stagiaire
                         where f.Nom == fNom
                         select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }

        public List<Stagiaire> getStagiaireForm(string fNom)
        {
            int numFormat = 0;
            formationsContext db = new formationsContext();

            List<Stagiaire> listearetourner = new List<Stagiaire>();
            var numForm = from nf in db.Formation
                          where nf.Nom == fNom
                          select nf.IdFormation;
            if (numForm.Count() > 0)
            {
                foreach (var elt in numForm)
                {
                    numFormat = elt;
                }
            }

            var format = from f in db.Stagiaire
                         where f.IdFormation == numFormat
                         select f;

            if (format.Count() > 0)
            {
                foreach (var elt in format)
                {
                    listearetourner.Add(elt);
                }
            }
            return listearetourner;
        }

        public List<Stagiaire> getStagiaireNiveau(string fNiv)
        {
            int numFormat = 0;
            formationsContext db = new formationsContext();

            List<Stagiaire> listearetourner = new List<Stagiaire>();
            var numForm = from nf in db.Formation
                          where nf.Niveau == fNiv
                          select nf.IdFormation;
            if (numForm.Count() > 0)
            {
                foreach (var elt in numForm)
                {
                    numFormat = elt;
                }
            }

            var format = from f in db.Stagiaire
                         where f.IdFormation == numFormat
                         select f;

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
