namespace ConsoleAppCheckBox
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrincipale = new System.Windows.Forms.TextBox();
            this.cbFond = new System.Windows.Forms.CheckBox();
            this.cbChar = new System.Windows.Forms.CheckBox();
            this.cbCasse = new System.Windows.Forms.CheckBox();
            this.rbFondRouge = new System.Windows.Forms.RadioButton();
            this.rbFondVert = new System.Windows.Forms.RadioButton();
            this.rbFondBleu = new System.Windows.Forms.RadioButton();
            this.rbCasseRouge = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // tbPrincipale
            // 
            this.tbPrincipale.Location = new System.Drawing.Point(42, 46);
            this.tbPrincipale.Name = "tbPrincipale";
            this.tbPrincipale.Size = new System.Drawing.Size(241, 20);
            this.tbPrincipale.TabIndex = 1;
            // 
            // cbFond
            // 
            this.cbFond.AutoSize = true;
            this.cbFond.Enabled = false;
            this.cbFond.Location = new System.Drawing.Point(612, 49);
            this.cbFond.Name = "cbFond";
            this.cbFond.Size = new System.Drawing.Size(101, 17);
            this.cbFond.TabIndex = 2;
            this.cbFond.Text = "Couleur du fond";
            this.cbFond.UseVisualStyleBackColor = true;
            // 
            // cbChar
            // 
            this.cbChar.AutoSize = true;
            this.cbChar.Enabled = false;
            this.cbChar.Location = new System.Drawing.Point(612, 73);
            this.cbChar.Name = "cbChar";
            this.cbChar.Size = new System.Drawing.Size(135, 17);
            this.cbChar.TabIndex = 3;
            this.cbChar.Text = "Couleur des caractéres";
            this.cbChar.UseVisualStyleBackColor = true;
            // 
            // cbCasse
            // 
            this.cbCasse.AutoSize = true;
            this.cbCasse.Enabled = false;
            this.cbCasse.Location = new System.Drawing.Point(612, 97);
            this.cbCasse.Name = "cbCasse";
            this.cbCasse.Size = new System.Drawing.Size(55, 17);
            this.cbCasse.TabIndex = 4;
            this.cbCasse.Text = "Casse";
            this.cbCasse.UseVisualStyleBackColor = true;
            // 
            // rbFondRouge
            // 
            this.rbFondRouge.AutoSize = true;
            this.rbFondRouge.Location = new System.Drawing.Point(84, 351);
            this.rbFondRouge.Name = "rbFondRouge";
            this.rbFondRouge.Size = new System.Drawing.Size(57, 17);
            this.rbFondRouge.TabIndex = 5;
            this.rbFondRouge.TabStop = true;
            this.rbFondRouge.Text = "Rouge";
            this.rbFondRouge.UseVisualStyleBackColor = true;
            // 
            // rbFondVert
            // 
            this.rbFondVert.AutoSize = true;
            this.rbFondVert.Location = new System.Drawing.Point(84, 375);
            this.rbFondVert.Name = "rbFondVert";
            this.rbFondVert.Size = new System.Drawing.Size(44, 17);
            this.rbFondVert.TabIndex = 6;
            this.rbFondVert.TabStop = true;
            this.rbFondVert.Text = "Vert";
            this.rbFondVert.UseVisualStyleBackColor = true;
            // 
            // rbFondBleu
            // 
            this.rbFondBleu.AutoSize = true;
            this.rbFondBleu.Location = new System.Drawing.Point(84, 399);
            this.rbFondBleu.Name = "rbFondBleu";
            this.rbFondBleu.Size = new System.Drawing.Size(46, 17);
            this.rbFondBleu.TabIndex = 7;
            this.rbFondBleu.TabStop = true;
            this.rbFondBleu.Text = "Bleu";
            this.rbFondBleu.UseVisualStyleBackColor = true;
            // 
            // rbCasseRouge
            // 
            this.rbCasseRouge.AutoSize = true;
            this.rbCasseRouge.Location = new System.Drawing.Point(197, 351);
            this.rbCasseRouge.Name = "rbCasseRouge";
            this.rbCasseRouge.Size = new System.Drawing.Size(57, 17);
            this.rbCasseRouge.TabIndex = 8;
            this.rbCasseRouge.TabStop = true;
            this.rbCasseRouge.Text = "Rouge";
            this.rbCasseRouge.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(197, 375);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbCasseRouge);
            this.Controls.Add(this.rbFondBleu);
            this.Controls.Add(this.rbFondVert);
            this.Controls.Add(this.rbFondRouge);
            this.Controls.Add(this.cbCasse);
            this.Controls.Add(this.cbChar);
            this.Controls.Add(this.cbFond);
            this.Controls.Add(this.tbPrincipale);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrincipale;
        private System.Windows.Forms.CheckBox cbFond;
        private System.Windows.Forms.CheckBox cbChar;
        private System.Windows.Forms.CheckBox cbCasse;
        private System.Windows.Forms.RadioButton rbFondRouge;
        private System.Windows.Forms.RadioButton rbFondVert;
        private System.Windows.Forms.RadioButton rbFondBleu;
        private System.Windows.Forms.RadioButton rbCasseRouge;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}