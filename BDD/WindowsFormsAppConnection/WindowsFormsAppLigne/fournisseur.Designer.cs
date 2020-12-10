
namespace WindowsFormsAppLigne
{
    partial class fournisseur
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
            this.lNom = new System.Windows.Forms.Label();
            this.lAdresse = new System.Windows.Forms.Label();
            this.lCP = new System.Windows.Forms.Label();
            this.lContact = new System.Windows.Forms.Label();
            this.lSatis = new System.Windows.Forms.Label();
            this.bRetour = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbSatisfaction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(46, 23);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lAdresse
            // 
            this.lAdresse.AutoSize = true;
            this.lAdresse.Location = new System.Drawing.Point(46, 66);
            this.lAdresse.Name = "lAdresse";
            this.lAdresse.Size = new System.Drawing.Size(45, 13);
            this.lAdresse.TabIndex = 1;
            this.lAdresse.Text = "Adresse";
            // 
            // lCP
            // 
            this.lCP.AutoSize = true;
            this.lCP.Location = new System.Drawing.Point(46, 106);
            this.lCP.Name = "lCP";
            this.lCP.Size = new System.Drawing.Size(51, 13);
            this.lCP.TabIndex = 2;
            this.lCP.Text = "CP / Ville";
            // 
            // lContact
            // 
            this.lContact.AutoSize = true;
            this.lContact.Location = new System.Drawing.Point(46, 154);
            this.lContact.Name = "lContact";
            this.lContact.Size = new System.Drawing.Size(44, 13);
            this.lContact.TabIndex = 3;
            this.lContact.Text = "Contact";
            // 
            // lSatis
            // 
            this.lSatis.AutoSize = true;
            this.lSatis.Location = new System.Drawing.Point(49, 211);
            this.lSatis.Name = "lSatis";
            this.lSatis.Size = new System.Drawing.Size(62, 13);
            this.lSatis.TabIndex = 4;
            this.lSatis.Text = "Satisfaction";
            // 
            // bRetour
            // 
            this.bRetour.Location = new System.Drawing.Point(198, 269);
            this.bRetour.Name = "bRetour";
            this.bRetour.Size = new System.Drawing.Size(75, 23);
            this.bRetour.TabIndex = 6;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = true;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            // 
            // tbNom
            // 
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(163, 20);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 7;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Enabled = false;
            this.tbAdresse.Location = new System.Drawing.Point(163, 63);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(100, 20);
            this.tbAdresse.TabIndex = 8;
            // 
            // tbContact
            // 
            this.tbContact.Enabled = false;
            this.tbContact.Location = new System.Drawing.Point(163, 147);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(100, 20);
            this.tbContact.TabIndex = 9;
            // 
            // tbCP
            // 
            this.tbCP.Enabled = false;
            this.tbCP.Location = new System.Drawing.Point(121, 103);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(45, 20);
            this.tbCP.TabIndex = 10;
            // 
            // tbVille
            // 
            this.tbVille.Enabled = false;
            this.tbVille.Location = new System.Drawing.Point(177, 103);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(86, 20);
            this.tbVille.TabIndex = 11;
            // 
            // tbSatisfaction
            // 
            this.tbSatisfaction.Enabled = false;
            this.tbSatisfaction.Location = new System.Drawing.Point(136, 208);
            this.tbSatisfaction.Name = "tbSatisfaction";
            this.tbSatisfaction.Size = new System.Drawing.Size(30, 20);
            this.tbSatisfaction.TabIndex = 12;
            // 
            // fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 315);
            this.Controls.Add(this.tbSatisfaction);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.lSatis);
            this.Controls.Add(this.lContact);
            this.Controls.Add(this.lCP);
            this.Controls.Add(this.lAdresse);
            this.Controls.Add(this.lNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lAdresse;
        private System.Windows.Forms.Label lCP;
        private System.Windows.Forms.Label lContact;
        private System.Windows.Forms.Label lSatis;
        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbSatisfaction;
    }
}