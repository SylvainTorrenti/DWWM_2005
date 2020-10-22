namespace WindowsFormsAppCheckBox
{
    partial class CheckBox
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
            this.lTexte = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.cbFond = new System.Windows.Forms.CheckBox();
            this.cbChar = new System.Windows.Forms.CheckBox();
            this.cbCasse = new System.Windows.Forms.CheckBox();
            this.rdFondRouge = new System.Windows.Forms.RadioButton();
            this.rdFondVert = new System.Windows.Forms.RadioButton();
            this.rdFondBleu = new System.Windows.Forms.RadioButton();
            this.rdCharRouge = new System.Windows.Forms.RadioButton();
            this.rdCharBlanc = new System.Windows.Forms.RadioButton();
            this.rdCharNoir = new System.Windows.Forms.RadioButton();
            this.rdMin = new System.Windows.Forms.RadioButton();
            this.rdMaj = new System.Windows.Forms.RadioButton();
            this.lModifier = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lTexte
            // 
            this.lTexte.AutoSize = true;
            this.lTexte.Location = new System.Drawing.Point(75, 29);
            this.lTexte.Name = "lTexte";
            this.lTexte.Size = new System.Drawing.Size(90, 13);
            this.lTexte.TabIndex = 0;
            this.lTexte.Text = "Tapez votre texte";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(78, 45);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(204, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // cbFond
            // 
            this.cbFond.AutoSize = true;
            this.cbFond.Enabled = false;
            this.cbFond.Location = new System.Drawing.Point(609, 45);
            this.cbFond.Name = "cbFond";
            this.cbFond.Size = new System.Drawing.Size(101, 17);
            this.cbFond.TabIndex = 2;
            this.cbFond.Text = "Couleur du fond";
            this.cbFond.UseVisualStyleBackColor = true;
            this.cbFond.CheckedChanged += new System.EventHandler(this.cbFond_CheckedChanged);
            // 
            // cbChar
            // 
            this.cbChar.AutoSize = true;
            this.cbChar.Enabled = false;
            this.cbChar.Location = new System.Drawing.Point(609, 78);
            this.cbChar.Name = "cbChar";
            this.cbChar.Size = new System.Drawing.Size(135, 17);
            this.cbChar.TabIndex = 3;
            this.cbChar.Text = "Couleur des caractéres";
            this.cbChar.UseVisualStyleBackColor = true;
            this.cbChar.CheckedChanged += new System.EventHandler(this.cbChar_CheckedChanged);
            // 
            // cbCasse
            // 
            this.cbCasse.AutoSize = true;
            this.cbCasse.Enabled = false;
            this.cbCasse.Location = new System.Drawing.Point(609, 115);
            this.cbCasse.Name = "cbCasse";
            this.cbCasse.Size = new System.Drawing.Size(55, 17);
            this.cbCasse.TabIndex = 4;
            this.cbCasse.Text = "Casse";
            this.cbCasse.UseVisualStyleBackColor = true;
            this.cbCasse.CheckedChanged += new System.EventHandler(this.cbCasse_CheckedChanged);
            // 
            // rdFondRouge
            // 
            this.rdFondRouge.AutoSize = true;
            this.rdFondRouge.Location = new System.Drawing.Point(78, 332);
            this.rdFondRouge.Name = "rdFondRouge";
            this.rdFondRouge.Size = new System.Drawing.Size(52, 17);
            this.rdFondRouge.TabIndex = 5;
            this.rdFondRouge.TabStop = true;
            this.rdFondRouge.Text = "rouge";
            this.rdFondRouge.UseVisualStyleBackColor = true;
            this.rdFondRouge.Visible = false;
            this.rdFondRouge.CheckedChanged += new System.EventHandler(this.rdFondRouge_CheckedChanged);
            // 
            // rdFondVert
            // 
            this.rdFondVert.AutoSize = true;
            this.rdFondVert.Location = new System.Drawing.Point(78, 355);
            this.rdFondVert.Name = "rdFondVert";
            this.rdFondVert.Size = new System.Drawing.Size(44, 17);
            this.rdFondVert.TabIndex = 6;
            this.rdFondVert.TabStop = true;
            this.rdFondVert.Text = "Vert";
            this.rdFondVert.UseVisualStyleBackColor = true;
            this.rdFondVert.Visible = false;
            this.rdFondVert.CheckedChanged += new System.EventHandler(this.rdFondVert_CheckedChanged);
            // 
            // rdFondBleu
            // 
            this.rdFondBleu.AutoSize = true;
            this.rdFondBleu.Location = new System.Drawing.Point(78, 378);
            this.rdFondBleu.Name = "rdFondBleu";
            this.rdFondBleu.Size = new System.Drawing.Size(46, 17);
            this.rdFondBleu.TabIndex = 7;
            this.rdFondBleu.TabStop = true;
            this.rdFondBleu.Text = "Bleu";
            this.rdFondBleu.UseVisualStyleBackColor = true;
            this.rdFondBleu.Visible = false;
            this.rdFondBleu.CheckedChanged += new System.EventHandler(this.rdFondBleu_CheckedChanged);
            // 
            // rdCharRouge
            // 
            this.rdCharRouge.AutoSize = true;
            this.rdCharRouge.Location = new System.Drawing.Point(176, 332);
            this.rdCharRouge.Name = "rdCharRouge";
            this.rdCharRouge.Size = new System.Drawing.Size(57, 17);
            this.rdCharRouge.TabIndex = 8;
            this.rdCharRouge.TabStop = true;
            this.rdCharRouge.Text = "Rouge";
            this.rdCharRouge.UseVisualStyleBackColor = true;
            this.rdCharRouge.Visible = false;
            this.rdCharRouge.CheckedChanged += new System.EventHandler(this.rdCharRouge_CheckedChanged);
            // 
            // rdCharBlanc
            // 
            this.rdCharBlanc.AutoSize = true;
            this.rdCharBlanc.Location = new System.Drawing.Point(176, 355);
            this.rdCharBlanc.Name = "rdCharBlanc";
            this.rdCharBlanc.Size = new System.Drawing.Size(52, 17);
            this.rdCharBlanc.TabIndex = 9;
            this.rdCharBlanc.TabStop = true;
            this.rdCharBlanc.Text = "Blanc";
            this.rdCharBlanc.UseVisualStyleBackColor = true;
            this.rdCharBlanc.Visible = false;
            this.rdCharBlanc.CheckedChanged += new System.EventHandler(this.rdCharBlanc_CheckedChanged);
            // 
            // rdCharNoir
            // 
            this.rdCharNoir.AutoSize = true;
            this.rdCharNoir.Location = new System.Drawing.Point(176, 379);
            this.rdCharNoir.Name = "rdCharNoir";
            this.rdCharNoir.Size = new System.Drawing.Size(44, 17);
            this.rdCharNoir.TabIndex = 10;
            this.rdCharNoir.TabStop = true;
            this.rdCharNoir.Text = "Noir";
            this.rdCharNoir.UseVisualStyleBackColor = true;
            this.rdCharNoir.Visible = false;
            this.rdCharNoir.CheckedChanged += new System.EventHandler(this.rdCharNoir_CheckedChanged);
            // 
            // rdMin
            // 
            this.rdMin.AutoSize = true;
            this.rdMin.Location = new System.Drawing.Point(275, 355);
            this.rdMin.Name = "rdMin";
            this.rdMin.Size = new System.Drawing.Size(78, 17);
            this.rdMin.TabIndex = 11;
            this.rdMin.TabStop = true;
            this.rdMin.Text = "Minuscules";
            this.rdMin.UseVisualStyleBackColor = true;
            this.rdMin.Visible = false;
            this.rdMin.CheckedChanged += new System.EventHandler(this.rdMin_CheckedChanged);
            // 
            // rdMaj
            // 
            this.rdMaj.AutoSize = true;
            this.rdMaj.Location = new System.Drawing.Point(275, 378);
            this.rdMaj.Name = "rdMaj";
            this.rdMaj.Size = new System.Drawing.Size(78, 17);
            this.rdMaj.TabIndex = 12;
            this.rdMaj.TabStop = true;
            this.rdMaj.Text = "Majuscules";
            this.rdMaj.UseVisualStyleBackColor = true;
            this.rdMaj.Visible = false;
            this.rdMaj.CheckedChanged += new System.EventHandler(this.rdMaj_CheckedChanged);
            // 
            // lModifier
            // 
            this.lModifier.AutoSize = true;
            this.lModifier.BackColor = System.Drawing.SystemColors.Control;
            this.lModifier.Location = new System.Drawing.Point(78, 115);
            this.lModifier.Name = "lModifier";
            this.lModifier.Size = new System.Drawing.Size(0, 13);
            this.lModifier.TabIndex = 13;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lModifier);
            this.Controls.Add(this.rdMaj);
            this.Controls.Add(this.rdMin);
            this.Controls.Add(this.rdCharNoir);
            this.Controls.Add(this.rdCharBlanc);
            this.Controls.Add(this.rdCharRouge);
            this.Controls.Add(this.rdFondBleu);
            this.Controls.Add(this.rdFondVert);
            this.Controls.Add(this.rdFondRouge);
            this.Controls.Add(this.cbCasse);
            this.Controls.Add(this.cbChar);
            this.Controls.Add(this.cbFond);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lTexte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTexte;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.CheckBox cbFond;
        private System.Windows.Forms.CheckBox cbChar;
        private System.Windows.Forms.CheckBox cbCasse;
        private System.Windows.Forms.RadioButton rdFondRouge;
        private System.Windows.Forms.RadioButton rdFondVert;
        private System.Windows.Forms.RadioButton rdFondBleu;
        private System.Windows.Forms.RadioButton rdCharRouge;
        private System.Windows.Forms.RadioButton rdCharBlanc;
        private System.Windows.Forms.RadioButton rdCharNoir;
        private System.Windows.Forms.RadioButton rdMin;
        private System.Windows.Forms.RadioButton rdMaj;
        private System.Windows.Forms.Label lModifier;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

