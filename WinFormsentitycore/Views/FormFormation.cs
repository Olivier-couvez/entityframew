using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsentitycore.DataAcess.dataObjects;
using WinFormsentitycore.Views;
using WinFormsentitycore.Bll;

namespace WinFormsentitycore
{
    public partial class Formformation : Form
    {
        DialogResult Fermeture;
        public Formformation()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formformation_Load(object sender, EventArgs e)
        {
            using var db = new formationsContext();
            gridFormation.DataSource = db.Formation.ToList();
            cBoxChoix.SelectedIndex = 0;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (cBoxChoix.SelectedIndex == 0)
            {
                AjouterFormation fenAjouterFormation = new AjouterFormation();
                Fermeture = fenAjouterFormation.ShowDialog();
                if (Fermeture != DialogResult.OK)
                {
                    MessageBox.Show("Création formation faite !");
                    using var db = new formationsContext();
                    gridFormation.DataSource = db.Formation.ToList();
                }
            }
            else
            {
                AjouterStagiaire fenAjouterStagiaire = new AjouterStagiaire();
                Fermeture = fenAjouterStagiaire.ShowDialog();
                if (Fermeture != DialogResult.OK)
                {
                    MessageBox.Show("Création stagiaire faite !");
                    using var db = new formationsContext();
                    gridFormation.DataSource = db.Stagiaire.ToList();
                }
            }

        }

        private void cBoxChoix_SelectedIndexChanged(object sender, EventArgs e)
        {     
            using var db = new formationsContext();
            switch (cBoxChoix.SelectedItem.ToString())
            {
                case "Formations":
                    gridFormation.DataSource = db.Formation.ToList();
                    break;
                case "Stagiaires":
                    gridFormation.DataSource = db.Stagiaire.ToList();
                    break;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(gridFormation.CurrentRow.Cells[0].Value.ToString());
            switch(cBoxChoix.SelectedIndex.ToString())
            {
                case "0":
                    BllFormation bllFormSupp = new BllFormation();
                    bllFormSupp.supprimerFormation(index);
                    break;
                case "1":
                    BllStagiaire bllStagSupp = new BllStagiaire();
                    bllStagSupp.supprimerStagiaire(index);
                    break;
            }
            cBoxChoix_SelectedIndexChanged(sender, e);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(gridFormation.CurrentRow.Cells[0].Value.ToString());
            switch (cBoxChoix.SelectedIndex.ToString())
            {
                case "0":
                    BllFormation bllFormSupp = new BllFormation();
                    bllFormSupp.ModificationFormation(index, gridFormation.CurrentRow.Cells[1].Value.ToString(), gridFormation.CurrentRow.Cells[2].Value.ToString(), Int32.Parse(gridFormation.CurrentRow.Cells[3].Value.ToString()));
                    break;
                case "1":
                    BllStagiaire bllStagSupp = new BllStagiaire();
                    bllStagSupp.modificationStagiaire(index, gridFormation.CurrentRow.Cells[1].Value.ToString(), gridFormation.CurrentRow.Cells[2].Value.ToString(), Int32.Parse(gridFormation.CurrentRow.Cells[3].Value.ToString()),Int32.Parse(gridFormation.CurrentRow.Cells[4].Value.ToString()));
                    break;
            }
            cBoxChoix_SelectedIndexChanged(sender, e);
        }
    }
}
