namespace WindowsFormsAppComboBox
{
    partial class LesListes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LesListes));
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDroite = new System.Windows.Forms.Button();
            this.bToutDroite = new System.Windows.Forms.Button();
            this.bToutGauche = new System.Windows.Forms.Button();
            this.bGauche = new System.Windows.Forms.Button();
            this.bHaut = new System.Windows.Forms.Button();
            this.bBas = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbListe
            // 
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(29, 79);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(145, 21);
            this.cbListe.TabIndex = 0;
            this.cbListe.DropDown += new System.EventHandler(this.cbListe_DropDown);
            this.cbListe.SelectedIndexChanged += new System.EventHandler(this.cbListe_SelectedIndexChanged);
            this.cbListe.TextChanged += new System.EventHandler(this.cbListe_TextChanged);
            this.cbListe.Enter += new System.EventHandler(this.cbListe_Enter);
            this.cbListe.Leave += new System.EventHandler(this.cbListe_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(287, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 238);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cible";
            // 
            // bDroite
            // 
            this.bDroite.Enabled = false;
            this.bDroite.Location = new System.Drawing.Point(190, 150);
            this.bDroite.Name = "bDroite";
            this.bDroite.Size = new System.Drawing.Size(33, 23);
            this.bDroite.TabIndex = 5;
            this.bDroite.Text = ">";
            this.bDroite.UseVisualStyleBackColor = true;
            this.bDroite.Click += new System.EventHandler(this.bDroite_Click);
            // 
            // bToutDroite
            // 
            this.bToutDroite.Location = new System.Drawing.Point(190, 179);
            this.bToutDroite.Name = "bToutDroite";
            this.bToutDroite.Size = new System.Drawing.Size(33, 23);
            this.bToutDroite.TabIndex = 6;
            this.bToutDroite.Text = ">>";
            this.bToutDroite.UseVisualStyleBackColor = true;
            this.bToutDroite.Click += new System.EventHandler(this.bToutDroite_Click);
            // 
            // bToutGauche
            // 
            this.bToutGauche.Enabled = false;
            this.bToutGauche.Location = new System.Drawing.Point(190, 242);
            this.bToutGauche.Name = "bToutGauche";
            this.bToutGauche.Size = new System.Drawing.Size(33, 23);
            this.bToutGauche.TabIndex = 7;
            this.bToutGauche.Text = "<<";
            this.bToutGauche.UseVisualStyleBackColor = true;
            this.bToutGauche.Click += new System.EventHandler(this.bToutGauche_Click);
            // 
            // bGauche
            // 
            this.bGauche.Enabled = false;
            this.bGauche.Location = new System.Drawing.Point(190, 213);
            this.bGauche.Name = "bGauche";
            this.bGauche.Size = new System.Drawing.Size(33, 23);
            this.bGauche.TabIndex = 8;
            this.bGauche.Text = "<";
            this.bGauche.UseVisualStyleBackColor = true;
            this.bGauche.Click += new System.EventHandler(this.bGauche_Click);
            // 
            // bHaut
            // 
            this.bHaut.Enabled = false;
            this.bHaut.Image = ((System.Drawing.Image)(resources.GetObject("bHaut.Image")));
            this.bHaut.Location = new System.Drawing.Point(298, 301);
            this.bHaut.Name = "bHaut";
            this.bHaut.Size = new System.Drawing.Size(41, 36);
            this.bHaut.TabIndex = 9;
            this.bHaut.UseVisualStyleBackColor = true;
            this.bHaut.Click += new System.EventHandler(this.bHaut_Click);
            // 
            // bBas
            // 
            this.bBas.Enabled = false;
            this.bBas.Image = ((System.Drawing.Image)(resources.GetObject("bBas.Image")));
            this.bBas.Location = new System.Drawing.Point(358, 301);
            this.bBas.Name = "bBas";
            this.bBas.Size = new System.Drawing.Size(41, 36);
            this.bBas.TabIndex = 10;
            this.bBas.UseVisualStyleBackColor = true;
            this.bBas.Click += new System.EventHandler(this.bBas_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // LesListes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 390);
            this.Controls.Add(this.bBas);
            this.Controls.Add(this.bHaut);
            this.Controls.Add(this.bGauche);
            this.Controls.Add(this.bToutGauche);
            this.Controls.Add(this.bToutDroite);
            this.Controls.Add(this.bDroite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LesListes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Listes";
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDroite;
        private System.Windows.Forms.Button bToutDroite;
        private System.Windows.Forms.Button bToutGauche;
        private System.Windows.Forms.Button bGauche;
        private System.Windows.Forms.Button bHaut;
        private System.Windows.Forms.Button bBas;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}

