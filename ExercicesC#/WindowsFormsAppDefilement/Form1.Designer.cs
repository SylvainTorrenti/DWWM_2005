namespace WindowsFormsAppDefilement
{
    partial class Defilement
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
            this.hSRouge = new System.Windows.Forms.HScrollBar();
            this.hSBleu = new System.Windows.Forms.HScrollBar();
            this.hSVert = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UPRouge = new System.Windows.Forms.NumericUpDown();
            this.UPVert = new System.Windows.Forms.NumericUpDown();
            this.UPBleu = new System.Windows.Forms.NumericUpDown();
            this.tbRouge = new System.Windows.Forms.TextBox();
            this.tbVert = new System.Windows.Forms.TextBox();
            this.tbBleu = new System.Windows.Forms.TextBox();
            this.tbFinale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UPRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // hSRouge
            // 
            this.hSRouge.LargeChange = 1;
            this.hSRouge.Location = new System.Drawing.Point(100, 27);
            this.hSRouge.Maximum = 255;
            this.hSRouge.Name = "hSRouge";
            this.hSRouge.Size = new System.Drawing.Size(345, 15);
            this.hSRouge.TabIndex = 0;
            this.hSRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSRouge_Scroll);
            // 
            // hSBleu
            // 
            this.hSBleu.LargeChange = 1;
            this.hSBleu.Location = new System.Drawing.Point(100, 148);
            this.hSBleu.Maximum = 255;
            this.hSBleu.Name = "hSBleu";
            this.hSBleu.Size = new System.Drawing.Size(345, 15);
            this.hSBleu.TabIndex = 1;
            this.hSBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBleu_Scroll);
            // 
            // hSVert
            // 
            this.hSVert.LargeChange = 1;
            this.hSVert.Location = new System.Drawing.Point(100, 89);
            this.hSVert.Maximum = 255;
            this.hSVert.Name = "hSVert";
            this.hSVert.Size = new System.Drawing.Size(345, 15);
            this.hSVert.TabIndex = 2;
            this.hSVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSVert_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rouge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bleu";
            // 
            // UPRouge
            // 
            this.UPRouge.Location = new System.Drawing.Point(462, 22);
            this.UPRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UPRouge.Name = "UPRouge";
            this.UPRouge.Size = new System.Drawing.Size(40, 20);
            this.UPRouge.TabIndex = 6;
            this.UPRouge.ValueChanged += new System.EventHandler(this.UPRouge_ValueChanged);
            // 
            // UPVert
            // 
            this.UPVert.Location = new System.Drawing.Point(462, 82);
            this.UPVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UPVert.Name = "UPVert";
            this.UPVert.Size = new System.Drawing.Size(40, 20);
            this.UPVert.TabIndex = 7;
            this.UPVert.ValueChanged += new System.EventHandler(this.UPVert_ValueChanged);
            // 
            // UPBleu
            // 
            this.UPBleu.Location = new System.Drawing.Point(462, 148);
            this.UPBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UPBleu.Name = "UPBleu";
            this.UPBleu.Size = new System.Drawing.Size(40, 20);
            this.UPBleu.TabIndex = 8;
            this.UPBleu.ValueChanged += new System.EventHandler(this.UPBleu_ValueChanged);
            // 
            // tbRouge
            // 
            this.tbRouge.Enabled = false;
            this.tbRouge.Location = new System.Drawing.Point(521, 22);
            this.tbRouge.Name = "tbRouge";
            this.tbRouge.Size = new System.Drawing.Size(22, 20);
            this.tbRouge.TabIndex = 17;
            // 
            // tbVert
            // 
            this.tbVert.Enabled = false;
            this.tbVert.Location = new System.Drawing.Point(521, 84);
            this.tbVert.Name = "tbVert";
            this.tbVert.Size = new System.Drawing.Size(22, 20);
            this.tbVert.TabIndex = 18;
            // 
            // tbBleu
            // 
            this.tbBleu.Enabled = false;
            this.tbBleu.Location = new System.Drawing.Point(521, 145);
            this.tbBleu.Name = "tbBleu";
            this.tbBleu.Size = new System.Drawing.Size(22, 20);
            this.tbBleu.TabIndex = 19;
            // 
            // tbFinale
            // 
            this.tbFinale.Enabled = false;
            this.tbFinale.Location = new System.Drawing.Point(100, 208);
            this.tbFinale.Multiline = true;
            this.tbFinale.Name = "tbFinale";
            this.tbFinale.Size = new System.Drawing.Size(345, 76);
            this.tbFinale.TabIndex = 20;
            // 
            // Defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.tbFinale);
            this.Controls.Add(this.tbBleu);
            this.Controls.Add(this.tbVert);
            this.Controls.Add(this.tbRouge);
            this.Controls.Add(this.UPBleu);
            this.Controls.Add(this.UPVert);
            this.Controls.Add(this.UPRouge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hSVert);
            this.Controls.Add(this.hSBleu);
            this.Controls.Add(this.hSRouge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Defilement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defilement";
            this.Load += new System.EventHandler(this.defilement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UPRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hSRouge;
        private System.Windows.Forms.HScrollBar hSBleu;
        private System.Windows.Forms.HScrollBar hSVert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UPRouge;
        private System.Windows.Forms.NumericUpDown UPVert;
        private System.Windows.Forms.NumericUpDown UPBleu;
        private System.Windows.Forms.TextBox tbRouge;
        private System.Windows.Forms.TextBox tbVert;
        private System.Windows.Forms.TextBox tbBleu;
        private System.Windows.Forms.TextBox tbFinale;
    }
}

