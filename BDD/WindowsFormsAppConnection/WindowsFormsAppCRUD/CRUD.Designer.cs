
namespace WindowsFormsAppCRUD
{
    partial class CRUD
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodeExistant = new System.Windows.Forms.TextBox();
            this.lFournisseur = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbSatisfaction = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.lAdresse = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.lCP = new System.Windows.Forms.Label();
            this.lStatisfaction = new System.Windows.Forms.Label();
            this.lVille = new System.Windows.Forms.Label();
            this.lContact = new System.Windows.Forms.Label();
            this.bCréé = new System.Windows.Forms.Button();
            this.Bupdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bRecherche = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCodeExistant
            // 
            this.tbCodeExistant.Location = new System.Drawing.Point(234, 35);
            this.tbCodeExistant.Name = "tbCodeExistant";
            this.tbCodeExistant.Size = new System.Drawing.Size(100, 20);
            this.tbCodeExistant.TabIndex = 0;
            // 
            // lFournisseur
            // 
            this.lFournisseur.AutoSize = true;
            this.lFournisseur.Location = new System.Drawing.Point(64, 38);
            this.lFournisseur.Name = "lFournisseur";
            this.lFournisseur.Size = new System.Drawing.Size(89, 13);
            this.lFournisseur.TabIndex = 1;
            this.lFournisseur.Text = "Code Fournisseur";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(352, 161);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 2;
            this.tbNom.Visible = false;
            // 
            // tbSatisfaction
            // 
            this.tbSatisfaction.Location = new System.Drawing.Point(352, 291);
            this.tbSatisfaction.Name = "tbSatisfaction";
            this.tbSatisfaction.Size = new System.Drawing.Size(100, 20);
            this.tbSatisfaction.TabIndex = 3;
            this.tbSatisfaction.Visible = false;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(352, 265);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(100, 20);
            this.tbContact.TabIndex = 4;
            this.tbContact.Visible = false;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(352, 239);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(100, 20);
            this.tbVille.TabIndex = 5;
            this.tbVille.Visible = false;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(352, 213);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(100, 20);
            this.tbCP.TabIndex = 6;
            this.tbCP.Visible = false;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(352, 187);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(100, 20);
            this.tbAdresse.TabIndex = 7;
            this.tbAdresse.Visible = false;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(352, 135);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 8;
            this.tbId.Visible = false;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(225, 142);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(18, 13);
            this.lId.TabIndex = 9;
            this.lId.Text = "ID";
            this.lId.Visible = false;
            // 
            // lAdresse
            // 
            this.lAdresse.AutoSize = true;
            this.lAdresse.Location = new System.Drawing.Point(225, 194);
            this.lAdresse.Name = "lAdresse";
            this.lAdresse.Size = new System.Drawing.Size(45, 13);
            this.lAdresse.TabIndex = 10;
            this.lAdresse.Text = "Adresse";
            this.lAdresse.Visible = false;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(225, 168);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 11;
            this.lNom.Text = "Nom";
            this.lNom.Visible = false;
            // 
            // lCP
            // 
            this.lCP.AutoSize = true;
            this.lCP.Location = new System.Drawing.Point(225, 220);
            this.lCP.Name = "lCP";
            this.lCP.Size = new System.Drawing.Size(64, 13);
            this.lCP.TabIndex = 12;
            this.lCP.Text = "Code Postal";
            this.lCP.Visible = false;
            // 
            // lStatisfaction
            // 
            this.lStatisfaction.AutoSize = true;
            this.lStatisfaction.Location = new System.Drawing.Point(225, 298);
            this.lStatisfaction.Name = "lStatisfaction";
            this.lStatisfaction.Size = new System.Drawing.Size(62, 13);
            this.lStatisfaction.TabIndex = 13;
            this.lStatisfaction.Text = "Satisfaction";
            this.lStatisfaction.Visible = false;
            // 
            // lVille
            // 
            this.lVille.AutoSize = true;
            this.lVille.Location = new System.Drawing.Point(225, 246);
            this.lVille.Name = "lVille";
            this.lVille.Size = new System.Drawing.Size(26, 13);
            this.lVille.TabIndex = 14;
            this.lVille.Text = "Ville";
            this.lVille.Visible = false;
            // 
            // lContact
            // 
            this.lContact.AutoSize = true;
            this.lContact.Location = new System.Drawing.Point(225, 272);
            this.lContact.Name = "lContact";
            this.lContact.Size = new System.Drawing.Size(44, 13);
            this.lContact.TabIndex = 15;
            this.lContact.Text = "Contact";
            this.lContact.Visible = false;
            // 
            // bCréé
            // 
            this.bCréé.Location = new System.Drawing.Point(67, 392);
            this.bCréé.Name = "bCréé";
            this.bCréé.Size = new System.Drawing.Size(75, 23);
            this.bCréé.TabIndex = 16;
            this.bCréé.Text = "Créé";
            this.bCréé.UseVisualStyleBackColor = true;
            this.bCréé.Click += new System.EventHandler(this.bCréé_Click);
            // 
            // Bupdate
            // 
            this.Bupdate.Enabled = false;
            this.Bupdate.Location = new System.Drawing.Point(168, 392);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(75, 23);
            this.Bupdate.TabIndex = 17;
            this.Bupdate.Text = "MaJ";
            this.Bupdate.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.Location = new System.Drawing.Point(259, 392);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Suppression";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRecherche
            // 
            this.bRecherche.Location = new System.Drawing.Point(366, 33);
            this.bRecherche.Name = "bRecherche";
            this.bRecherche.Size = new System.Drawing.Size(75, 23);
            this.bRecherche.TabIndex = 19;
            this.bRecherche.Text = "Chercher";
            this.bRecherche.UseVisualStyleBackColor = true;
            this.bRecherche.Click += new System.EventHandler(this.bRecherche_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(523, 423);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 20;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(67, 422);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 23);
            this.bAjouter.TabIndex = 21;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Visible = false;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 458);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bRecherche);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.bCréé);
            this.Controls.Add(this.lContact);
            this.Controls.Add(this.lVille);
            this.Controls.Add(this.lStatisfaction);
            this.Controls.Add(this.lCP);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.lAdresse);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbSatisfaction);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lFournisseur);
            this.Controls.Add(this.tbCodeExistant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodeExistant;
        private System.Windows.Forms.Label lFournisseur;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbSatisfaction;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lAdresse;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lCP;
        private System.Windows.Forms.Label lStatisfaction;
        private System.Windows.Forms.Label lVille;
        private System.Windows.Forms.Label lContact;
        private System.Windows.Forms.Button bCréé;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bRecherche;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Button bAjouter;
    }
}

