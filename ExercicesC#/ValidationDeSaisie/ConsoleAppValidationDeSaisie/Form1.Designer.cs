namespace ConsoleAppValidationDeSaisie
{
    partial class LesControle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(52, 55);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(52, 84);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(52, 117);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(46, 13);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(52, 149);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(64, 13);
            this.labelCP.TabIndex = 3;
            this.labelCP.Text = "Code Postal";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(151, 55);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 4;
            this.tbNom.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(151, 84);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 5;
            this.tbDate.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(151, 117);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(100, 20);
            this.tbMontant.TabIndex = 6;
            this.tbMontant.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(151, 149);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(100, 20);
            this.tbCP.TabIndex = 7;
            this.tbCP.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(309, 196);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(309, 225);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeftChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // LesControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 259);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LesControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Contrôles";
            this.Load += new System.EventHandler(this.LesControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}