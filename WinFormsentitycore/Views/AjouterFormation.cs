using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsentitycore.Bll;

namespace WinFormsentitycore.Views
{
    public partial class AjouterFormation : Form
    {
        public AjouterFormation()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            BllFormation nouvelleformation = new BllFormation();
            nouvelleformation.AjouterFormation(textBoxNom.Text, textBoxNiveau.Text, Convert.ToInt16(textBoxNbStagiaire.Text));
            this.Close();
        }
    }
}
