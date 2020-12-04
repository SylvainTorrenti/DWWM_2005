
namespace WindowsFormsAppEmprunt
{
    partial class Emprunt
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
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCE = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelPeriodeRemboursement = new System.Windows.Forms.Label();
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.labelNbRemboursement = new System.Windows.Forms.Label();
            this.labelMontantRemboursement = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbCE = new System.Windows.Forms.TextBox();
            this.labelDureeModif = new System.Windows.Forms.Label();
            this.hsEmprunt = new System.Windows.Forms.HScrollBar();
            this.gbInteret = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.bOk = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbEmprunt = new System.Windows.Forms.ListBox();
            this.gbInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(91, 58);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelCE
            // 
            this.labelCE.AutoSize = true;
            this.labelCE.Location = new System.Drawing.Point(94, 115);
            this.labelCE.Name = "labelCE";
            this.labelCE.Size = new System.Drawing.Size(87, 13);
            this.labelCE.TabIndex = 1;
            this.labelCE.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(97, 182);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(165, 13);
            this.labelDuree.TabIndex = 2;
            this.labelDuree.Text = "Durée en mois du remboursement";
            // 
            // labelPeriodeRemboursement
            // 
            this.labelPeriodeRemboursement.AutoSize = true;
            this.labelPeriodeRemboursement.Location = new System.Drawing.Point(91, 293);
            this.labelPeriodeRemboursement.Name = "labelPeriodeRemboursement";
            this.labelPeriodeRemboursement.Size = new System.Drawing.Size(146, 13);
            this.labelPeriodeRemboursement.TabIndex = 3;
            this.labelPeriodeRemboursement.Text = "Périodicité de remboursement";
            // 
            // labelRemboursement
            // 
            this.labelRemboursement.AutoSize = true;
            this.labelRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemboursement.Location = new System.Drawing.Point(583, 262);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(150, 20);
            this.labelRemboursement.TabIndex = 4;
            this.labelRemboursement.Text = "Remboursements";
            // 
            // labelNbRemboursement
            // 
            this.labelNbRemboursement.AutoSize = true;
            this.labelNbRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelNbRemboursement.Location = new System.Drawing.Point(546, 267);
            this.labelNbRemboursement.Name = "labelNbRemboursement";
            this.labelNbRemboursement.Size = new System.Drawing.Size(13, 13);
            this.labelNbRemboursement.TabIndex = 5;
            this.labelNbRemboursement.Text = "0";
            // 
            // labelMontantRemboursement
            // 
            this.labelMontantRemboursement.AutoSize = true;
            this.labelMontantRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelMontantRemboursement.Location = new System.Drawing.Point(587, 296);
            this.labelMontantRemboursement.Name = "labelMontantRemboursement";
            this.labelMontantRemboursement.Size = new System.Drawing.Size(13, 13);
            this.labelMontantRemboursement.TabIndex = 6;
            this.labelMontantRemboursement.Text = "0";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(285, 50);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 7;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // tbCE
            // 
            this.tbCE.Location = new System.Drawing.Point(285, 107);
            this.tbCE.Name = "tbCE";
            this.tbCE.Size = new System.Drawing.Size(100, 20);
            this.tbCE.TabIndex = 8;
            this.tbCE.TextChanged += new System.EventHandler(this.tbCE_TextChanged);
            // 
            // labelDureeModif
            // 
            this.labelDureeModif.AutoSize = true;
            this.labelDureeModif.Location = new System.Drawing.Point(285, 181);
            this.labelDureeModif.Name = "labelDureeModif";
            this.labelDureeModif.Size = new System.Drawing.Size(13, 13);
            this.labelDureeModif.TabIndex = 9;
            this.labelDureeModif.Text = "1";
            // 
            // hsEmprunt
            // 
            this.hsEmprunt.Location = new System.Drawing.Point(341, 177);
            this.hsEmprunt.Name = "hsEmprunt";
            this.hsEmprunt.Size = new System.Drawing.Size(162, 17);
            this.hsEmprunt.TabIndex = 10;
            this.hsEmprunt.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsEmprunt_Scroll);
            // 
            // gbInteret
            // 
            this.gbInteret.Controls.Add(this.rb9);
            this.gbInteret.Controls.Add(this.rb8);
            this.gbInteret.Controls.Add(this.rb7);
            this.gbInteret.Location = new System.Drawing.Point(542, 50);
            this.gbInteret.Name = "gbInteret";
            this.gbInteret.Size = new System.Drawing.Size(88, 88);
            this.gbInteret.TabIndex = 11;
            this.gbInteret.TabStop = false;
            this.gbInteret.Text = "Taux d\'intérêt";
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(7, 68);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(42, 17);
            this.rb9.TabIndex = 2;
            this.rb9.TabStop = true;
            this.rb9.Text = "9 %";
            this.rb9.UseVisualStyleBackColor = true;
            this.rb9.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(7, 44);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(42, 17);
            this.rb8.TabIndex = 1;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 %";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Checked = true;
            this.rb7.Location = new System.Drawing.Point(7, 20);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(42, 17);
            this.rb7.TabIndex = 0;
            this.rb7.TabStop = true;
            this.rb7.Text = "7 %";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // bOk
            // 
            this.bOk.Enabled = false;
            this.bOk.Location = new System.Drawing.Point(657, 50);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 13;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(657, 94);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 14;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // lbEmprunt
            // 
            this.lbEmprunt.FormattingEnabled = true;
            this.lbEmprunt.Location = new System.Drawing.Point(94, 320);
            this.lbEmprunt.Name = "lbEmprunt";
            this.lbEmprunt.Size = new System.Drawing.Size(190, 95);
            this.lbEmprunt.TabIndex = 15;
            this.lbEmprunt.SelectedIndexChanged += new System.EventHandler(this.lbEmprunt_SelectedIndexChanged);
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEmprunt);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.gbInteret);
            this.Controls.Add(this.hsEmprunt);
            this.Controls.Add(this.labelDureeModif);
            this.Controls.Add(this.tbCE);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.labelMontantRemboursement);
            this.Controls.Add(this.labelNbRemboursement);
            this.Controls.Add(this.labelRemboursement);
            this.Controls.Add(this.labelPeriodeRemboursement);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelCE);
            this.Controls.Add(this.labelNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Emprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.gbInteret.ResumeLayout(false);
            this.gbInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCE;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.Label labelPeriodeRemboursement;
        private System.Windows.Forms.Label labelRemboursement;
        private System.Windows.Forms.Label labelNbRemboursement;
        private System.Windows.Forms.Label labelMontantRemboursement;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbCE;
        private System.Windows.Forms.Label labelDureeModif;
        private System.Windows.Forms.HScrollBar hsEmprunt;
        private System.Windows.Forms.GroupBox gbInteret;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.ListBox lbEmprunt;
    }
}

