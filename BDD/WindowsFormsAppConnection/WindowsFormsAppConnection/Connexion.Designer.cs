
namespace WindowsFormsAppConnection
{
    partial class Connexion
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
            this.lServeur = new System.Windows.Forms.Label();
            this.lBDD = new System.Windows.Forms.Label();
            this.tbServeur = new System.Windows.Forms.TextBox();
            this.tbBDD = new System.Windows.Forms.TextBox();
            this.bConnexion = new System.Windows.Forms.Button();
            this.bDeconnexion = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.lEC = new System.Windows.Forms.Label();
            this.lConnexion = new System.Windows.Forms.Label();
            this.tbErreur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lServeur
            // 
            this.lServeur.AutoSize = true;
            this.lServeur.Location = new System.Drawing.Point(33, 43);
            this.lServeur.Name = "lServeur";
            this.lServeur.Size = new System.Drawing.Size(50, 13);
            this.lServeur.TabIndex = 0;
            this.lServeur.Text = "Serveur :";
            // 
            // lBDD
            // 
            this.lBDD.AutoSize = true;
            this.lBDD.Location = new System.Drawing.Point(36, 78);
            this.lBDD.Name = "lBDD";
            this.lBDD.Size = new System.Drawing.Size(96, 13);
            this.lBDD.TabIndex = 1;
            this.lBDD.Text = "Base de données :";
            // 
            // tbServeur
            // 
            this.tbServeur.Location = new System.Drawing.Point(163, 35);
            this.tbServeur.Name = "tbServeur";
            this.tbServeur.Size = new System.Drawing.Size(201, 20);
            this.tbServeur.TabIndex = 2;
            // 
            // tbBDD
            // 
            this.tbBDD.Location = new System.Drawing.Point(163, 78);
            this.tbBDD.Name = "tbBDD";
            this.tbBDD.Size = new System.Drawing.Size(201, 20);
            this.tbBDD.TabIndex = 3;
            // 
            // bConnexion
            // 
            this.bConnexion.Location = new System.Drawing.Point(39, 140);
            this.bConnexion.Name = "bConnexion";
            this.bConnexion.Size = new System.Drawing.Size(75, 23);
            this.bConnexion.TabIndex = 4;
            this.bConnexion.Text = "Connexion";
            this.bConnexion.UseVisualStyleBackColor = true;
            this.bConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // bDeconnexion
            // 
            this.bDeconnexion.Location = new System.Drawing.Point(173, 140);
            this.bDeconnexion.Name = "bDeconnexion";
            this.bDeconnexion.Size = new System.Drawing.Size(90, 23);
            this.bDeconnexion.TabIndex = 5;
            this.bDeconnexion.Text = "Déconnexion";
            this.bDeconnexion.UseVisualStyleBackColor = true;
            this.bDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(173, 170);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(90, 23);
            this.bQuitter.TabIndex = 6;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // lEC
            // 
            this.lEC.AutoSize = true;
            this.lEC.Location = new System.Drawing.Point(39, 239);
            this.lEC.Name = "lEC";
            this.lEC.Size = new System.Drawing.Size(104, 13);
            this.lEC.TabIndex = 7;
            this.lEC.Text = "Etat de la connexion";
            // 
            // lConnexion
            // 
            this.lConnexion.AutoSize = true;
            this.lConnexion.Location = new System.Drawing.Point(173, 239);
            this.lConnexion.Name = "lConnexion";
            this.lConnexion.Size = new System.Drawing.Size(39, 13);
            this.lConnexion.TabIndex = 8;
            this.lConnexion.Text = "Closed";
            // 
            // tbErreur
            // 
            this.tbErreur.Location = new System.Drawing.Point(36, 287);
            this.tbErreur.Multiline = true;
            this.tbErreur.Name = "tbErreur";
            this.tbErreur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErreur.Size = new System.Drawing.Size(227, 129);
            this.tbErreur.TabIndex = 9;
            this.tbErreur.Visible = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 440);
            this.Controls.Add(this.tbErreur);
            this.Controls.Add(this.lConnexion);
            this.Controls.Add(this.lEC);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bDeconnexion);
            this.Controls.Add(this.bConnexion);
            this.Controls.Add(this.tbBDD);
            this.Controls.Add(this.tbServeur);
            this.Controls.Add(this.lBDD);
            this.Controls.Add(this.lServeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lServeur;
        private System.Windows.Forms.Label lBDD;
        private System.Windows.Forms.TextBox tbServeur;
        private System.Windows.Forms.TextBox tbBDD;
        private System.Windows.Forms.Button bConnexion;
        private System.Windows.Forms.Button bDeconnexion;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Label lEC;
        private System.Windows.Forms.Label lConnexion;
        private System.Windows.Forms.TextBox tbErreur;
    }
}

