using System;
using System.Collections.Generic;
using System.Text;
using WinFormsentitycore.DataAcess.dataObjects;

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
    }
}
