
namespace WindowsFormsAppLigne
{
    partial class Ligne
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
            this.lCF = new System.Windows.Forms.Label();
            this.bValider = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.tbFournisseur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lCF
            // 
            this.lCF.AutoSize = true;
            this.lCF.Location = new System.Drawing.Point(70, 49);
            this.lCF.Name = "lCF";
            this.lCF.Size = new System.Drawing.Size(86, 13);
            this.lCF.TabIndex = 0;
            this.lCF.Text = "Code fournisseur";
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(73, 100);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 1;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(306, 99);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 2;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // tbFournisseur
            // 
            this.tbFournisseur.Location = new System.Drawing.Point(306, 41);
            this.tbFournisseur.Name = "tbFournisseur";
            this.tbFournisseur.Size = new System.Drawing.Size(75, 20);
            this.tbFournisseur.TabIndex = 3;
            // 
            // Ligne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 155);
            this.Controls.Add(this.tbFournisseur);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.lCF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ligne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affichage fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCF;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.TextBox tbFournisseur;
    }
}

