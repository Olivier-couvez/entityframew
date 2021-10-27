
namespace WinFormsentitycore
{
    partial class Formformation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridFormation = new System.Windows.Forms.DataGridView();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.cBoxChoix = new System.Windows.Forms.ComboBox();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.cBoxFiltre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormation)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFormation
            // 
            this.gridFormation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormation.Location = new System.Drawing.Point(75, 107);
            this.gridFormation.Name = "gridFormation";
            this.gridFormation.RowTemplate.Height = 25;
            this.gridFormation.Size = new System.Drawing.Size(595, 239);
            this.gridFormation.TabIndex = 0;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(75, 374);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(232, 374);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(406, 374);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(699, 415);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(584, 374);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 5;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // cBoxChoix
            // 
            this.cBoxChoix.FormattingEnabled = true;
            this.cBoxChoix.Items.AddRange(new object[] {
            "Formations",
            "Stagiaires"});
            this.cBoxChoix.Location = new System.Drawing.Point(193, 39);
            this.cBoxChoix.Name = "cBoxChoix";
            this.cBoxChoix.Size = new System.Drawing.Size(152, 23);
            this.cBoxChoix.TabIndex = 6;
            this.cBoxChoix.SelectedIndexChanged += new System.EventHandler(this.cBoxChoix_SelectedIndexChanged);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Location = new System.Drawing.Point(75, 39);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(90, 15);
            this.lblAffichage.TabIndex = 7;
            this.lblAffichage.Text = "Choix affichage";
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Location = new System.Drawing.Point(406, 42);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(33, 15);
            this.lblFiltre.TabIndex = 8;
            this.lblFiltre.Text = "Filtre";
            // 
            // cBoxFiltre
            // 
            this.cBoxFiltre.FormattingEnabled = true;
            this.cBoxFiltre.Items.AddRange(new object[] {
            "Formations par nombre de stagiaire",
            "Stagiaires par nom",
            "Stagiaires par prénom",
            "Stagiaires d\'une formation",
            "Stagiaire par niveau de formation"});
            this.cBoxFiltre.Location = new System.Drawing.Point(496, 39);
            this.cBoxFiltre.Name = "cBoxFiltre";
            this.cBoxFiltre.Size = new System.Drawing.Size(152, 23);
            this.cBoxFiltre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "A rechercher :";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(496, 68);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(237, 23);
            this.textBoxRecherche.TabIndex = 11;
            // 
            // Formformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxFiltre);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.cBoxChoix);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.gridFormation);
            this.Name = "Formformation";
            this.Text = "Les Formations";
            this.Load += new System.EventHandler(this.Formformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFormation;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ComboBox cBoxChoix;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.ComboBox cBoxFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRecherche;
    }
}

