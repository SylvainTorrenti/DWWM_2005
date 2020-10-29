namespace WindowsFormsAppListeBox
{
    partial class ListeBox
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
            this.lbNom = new System.Windows.Forms.ListBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.bEffacer = new System.Windows.Forms.Button();
            this.Propriétés = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIC = new System.Windows.Forms.TextBox();
            this.tbSI = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSI = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSI)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.FormattingEnabled = true;
            this.lbNom.Location = new System.Drawing.Point(33, 227);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(155, 173);
            this.lbNom.TabIndex = 0;
            this.lbNom.SelectedIndexChanged += new System.EventHandler(this.lbNom_SelectedIndexChanged);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(33, 80);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(155, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot";
            // 
            // bAjouter
            // 
            this.bAjouter.Enabled = false;
            this.bAjouter.Location = new System.Drawing.Point(33, 138);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(155, 40);
            this.bAjouter.TabIndex = 3;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index Element";
            // 
            // tbIndex
            // 
            this.tbIndex.Enabled = false;
            this.tbIndex.Location = new System.Drawing.Point(355, 80);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(29, 20);
            this.tbIndex.TabIndex = 5;
            this.tbIndex.TextChanged += new System.EventHandler(this.tbIndex_TextChanged);
            // 
            // bSelect
            // 
            this.bSelect.Enabled = false;
            this.bSelect.Location = new System.Drawing.Point(400, 77);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 6;
            this.bSelect.Text = "Selectionner";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bEffacer
            // 
            this.bEffacer.Enabled = false;
            this.bEffacer.Location = new System.Drawing.Point(400, 121);
            this.bEffacer.Name = "bEffacer";
            this.bEffacer.Size = new System.Drawing.Size(75, 23);
            this.bEffacer.TabIndex = 7;
            this.bEffacer.Text = "Effacer";
            this.bEffacer.UseVisualStyleBackColor = true;
            this.bEffacer.Click += new System.EventHandler(this.bEffacer_Click);
            // 
            // Propriétés
            // 
            this.Propriétés.AutoSize = true;
            this.Propriétés.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Propriétés.Location = new System.Drawing.Point(331, 200);
            this.Propriétés.Name = "Propriétés";
            this.Propriétés.Size = new System.Drawing.Size(91, 20);
            this.Propriétés.TabIndex = 8;
            this.Propriétés.Text = "Propriétés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item.Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SelectedIndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Text";
            // 
            // tbIC
            // 
            this.tbIC.Enabled = false;
            this.tbIC.Location = new System.Drawing.Point(419, 240);
            this.tbIC.Name = "tbIC";
            this.tbIC.Size = new System.Drawing.Size(24, 20);
            this.tbIC.TabIndex = 12;
            // 
            // tbSI
            // 
            this.tbSI.Enabled = false;
            this.tbSI.Location = new System.Drawing.Point(420, 287);
            this.tbSI.Name = "tbSI";
            this.tbSI.Size = new System.Drawing.Size(24, 20);
            this.tbSI.TabIndex = 13;
            // 
            // tbText
            // 
            this.tbText.Enabled = false;
            this.tbText.Location = new System.Drawing.Point(419, 329);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 20);
            this.tbText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "LstListe";
            // 
            // epInput
            // 
            this.epInput.ContainerControl = this;
            // 
            // epNom
            // 
            this.epNom.ContainerControl = this;
            // 
            // epSI
            // 
            this.epSI.ContainerControl = this;
            // 
            // ListeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 424);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbSI);
            this.Controls.Add(this.tbIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Propriétés);
            this.Controls.Add(this.bEffacer);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Box";
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNom;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bEffacer;
        private System.Windows.Forms.Label Propriétés;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIC;
        private System.Windows.Forms.TextBox tbSI;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epInput;
        private System.Windows.Forms.ErrorProvider epNom;
        private System.Windows.Forms.ErrorProvider epSI;
    }
}

