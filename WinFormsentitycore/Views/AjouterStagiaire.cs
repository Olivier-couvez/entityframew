using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsentitycore.Bll;
using WinFormsentitycore.DataAcess.dataObjects;

namespace WinFormsentitycore.Views
{
    public partial class AjouterStagiaire : Form
    {
        List<Formation> listeFormation;
        public AjouterStagiaire()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            BllStagiaire nouveauStagiaire = new BllStagiaire();
            int idform = 0;
            foreach (Formation elt in listeFormation)
            {
                if (elt.Nom == cBoxFormation.SelectedItem.ToString())
                {
                    idform = elt.IdFormation;
                }
            }
            nouveauStagiaire.AjouterStagiaire(textBoxNom.Text, textBoxPrenom.Text, Convert.ToInt16(textBoxAge.Text), idform);
            this.Close();
        }

        private void AjouterStagiaire_Load(object sender, EventArgs e)
        {
            BllFormation listForm = new BllFormation();
            
            listeFormation = listForm.getStagiaireFormation();
            foreach (Formation elt in listeFormation)
            {
                cBoxFormation.Items.Add(elt.Nom);
            }
            cBoxFormation.SelectedIndex = 0;
        }
    }
}
