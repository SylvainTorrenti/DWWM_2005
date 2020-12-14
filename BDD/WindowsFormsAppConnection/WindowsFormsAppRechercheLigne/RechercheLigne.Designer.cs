
namespace WindowsFormsAppRechercheLigne
{
    partial class Liste
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
            this.lChoix = new System.Windows.Forms.Label();
            this.cbFournisseur = new System.Windows.Forms.ComboBox();
            this.lbFournisseur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lChoix
            // 
            this.lChoix.AutoSize = true;
            this.lChoix.Location = new System.Drawing.Point(49, 30);
            this.lChoix.Name = "lChoix";
            this.lChoix.Size = new System.Drawing.Size(107, 13);
            this.lChoix.TabIndex = 0;
            this.lChoix.Text = "Choisir un fournisseur";
            // 
            // cbFournisseur
            // 
            this.cbFournisseur.FormattingEnabled = true;
            this.cbFournisseur.Location = new System.Drawing.Point(199, 30);
            this.cbFournisseur.Name = "cbFournisseur";
            this.cbFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbFournisseur.TabIndex = 1;
            this.cbFournisseur.SelectedIndexChanged += new System.EventHandler(this.cbFournisseur_SelectedIndexChanged);
            // 
            // lbFournisseur
            // 
            this.lbFournisseur.FormattingEnabled = true;
            this.lbFournisseur.Location = new System.Drawing.Point(98, 149);
            this.lbFournisseur.Name = "lbFournisseur";
            this.lbFournisseur.Size = new System.Drawing.Size(270, 95);
            this.lbFournisseur.TabIndex = 2;
            this.lbFournisseur.Visible = false;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 321);
            this.Controls.Add(this.lbFournisseur);
            this.Controls.Add(this.cbFournisseur);
            this.Controls.Add(this.lChoix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lChoix;
        private System.Windows.Forms.ComboBox cbFournisseur;
        private System.Windows.Forms.ListBox lbFournisseur;
    }
}

