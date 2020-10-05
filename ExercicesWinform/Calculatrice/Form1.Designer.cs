namespace Calculatrice
{
    partial class calculatrice
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
            this.resultat = new System.Windows.Forms.RichTextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(12, 12);
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.resultat.Size = new System.Drawing.Size(471, 128);
            this.resultat.TabIndex = 1;
            this.resultat.Text = "";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 196);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(91, 49);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(400, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 49);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 49);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(109, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(206, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 49);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(303, 251);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 49);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(12, 336);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(188, 46);
            this.vider.TabIndex = 13;
            this.vider.Text = "vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // calculer
            // 
            this.calculer.Location = new System.Drawing.Point(303, 336);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(188, 46);
            this.calculer.TabIndex = 14;
            this.calculer.Text = "calculer";
            this.calculer.UseVisualStyleBackColor = true;
            this.calculer.Click += new System.EventHandler(this.calculer_Click);
            // 
            // calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.calculer);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.resultat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "calculatrice";
            this.Text = "calculatrice";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultat;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.Button calculer;
    }
}

