namespace ConsoleAppValidationDeSaisie
{
    partial class LesControle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Montant";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(172, 47);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            this.tbNom.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.tbNom.Leave += new System.EventHandler(this.focus_nom);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(172, 79);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 4;
            this.tbDate.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.tbDate.Leave += new System.EventHandler(this.focus_date);
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(172, 113);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(100, 20);
            this.tbMontant.TabIndex = 5;
            this.tbMontant.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.tbMontant.Leave += new System.EventHandler(this.focus_montant);
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(172, 146);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(100, 20);
            this.tbCP.TabIndex = 6;
            this.tbCP.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.tbCP.Leave += new System.EventHandler(this.focus_CP);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code Postal";
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Location = new System.Drawing.Point(305, 193);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click_1);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(305, 236);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LesControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 268);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LesControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

