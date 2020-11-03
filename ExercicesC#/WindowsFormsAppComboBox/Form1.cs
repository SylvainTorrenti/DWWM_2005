using System;
using System.Windows.Forms;

namespace WindowsFormsAppComboBox
{
    public partial class LesListes : Form
    {
        public LesListes()
        {
            InitializeComponent();
            cbListe.Items.Add("France");
            cbListe.Items.Add("Belgique");
            cbListe.Items.Add("Bulgarie");
            cbListe.Items.Add("Espagne");
            cbListe.Items.Add("Allemagne");
            cbListe.Items.Add("Japon");
            cbListe.Items.Add("Portugal");
            cbListe.Items.Add("Grece");
        }
        /// <summary>
        /// Add text input in target textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDroite_Click(object sender, EventArgs e)
        {
            if (cbListe.SelectedIndex == -1)
            {
                listBox1.Items.Add(cbListe.Text);
                cbListe.Text = "";
                cbListe.Items.Remove(cbListe.SelectedItem);
                bDroite.Enabled = false;

            }

            else
            {
                listBox1.Items.Add(cbListe.SelectedItem);
                cbListe.Items.Remove(cbListe.SelectedItem);
                cbListe.Text = "";
                bDroite.Enabled = true;

            }
            bDroite.Enabled = false;
            bToutGauche.Enabled = true;
            ep1.Clear();
        }


        /// <summary>
        /// Add all text in list in target textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bToutDroite_Click(object sender, EventArgs e)
        {
            foreach (string s in cbListe.Items)
            {
                listBox1.Items.Add(s);
            }
            cbListe.Items.Clear();
            bToutDroite.Enabled = false;
            bToutGauche.Enabled = true;
            cbListe.ResetText();
            ep1.Clear();
        }
        /// <summary>
        /// Remove all text in targetbox in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bToutGauche_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.Items)
            {
                cbListe.Items.Add(s);
            }
            listBox1.Items.Clear();
            bToutGauche.Enabled = false;
            bToutDroite.Enabled = true;
            bGauche.Enabled = false;
            bHaut.Enabled = false;
            bBas.Enabled = false;
            ep1.Clear();
        }
        /// <summary>
        /// Remove the select text in target textbox in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGauche_Click(object sender, EventArgs e)
        {

            cbListe.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            bToutDroite.Enabled = true;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            ep1.Clear();
        }
        /// <summary>
        /// When you select text in target textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                bBas.Enabled = false;
                bHaut.Enabled = false;
                bGauche.Enabled = false;

            }
            else
            {
                bHaut.Enabled = true;
                bBas.Enabled = true;
                bGauche.Enabled = true;
            }
            ep1.Clear();

        }
        /// <summary>
        /// move up the select text in target textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bHaut_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                int pays = listBox1.SelectedIndex;
                object pTemps = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(pays);
                listBox1.Items.Insert(pays - 1, pTemps);
                listBox1.SelectedIndex = pays - 1;
            }
            else if (listBox1.SelectedIndex == 0)
            {
                bHaut.Enabled = false;
            }
            ep1.Clear();

        }
        /// <summary>
        /// move down the select text in target textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBas_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                int pays = listBox1.SelectedIndex;
                object pTemp = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(pays);
                listBox1.Items.Insert(pays + 1, pTemp);
                listBox1.SelectedIndex = pays + 1;
            }
            else if(listBox1.SelectedIndex == listBox1.Items.Count -1)
            {
                bBas.Enabled = false;
            }

            
            ep1.Clear();

        }
        /// <summary>
        /// Add text in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListe_DropDown(object sender, EventArgs e)
        {
            ep1.Clear();
            string text = cbListe.Text;
            int taille = text.Length;
            if (taille >= 2)
            {
                bool doublon1 = cbListe.Items.Contains(cbListe.Text);
                bool doublon2 = listBox1.Items.Contains(cbListe.Text);
                if (doublon1 == true)
                {
                    ep1.SetError(cbListe, "Il y a un doublon dans la liste");
                }
                else if (doublon2 == true)
                {
                    ep1.SetError(cbListe, "Il y a un doublon dans la box cible");
                }
                else
                {
                    cbListe.Items.Add(cbListe.Text);
                }


            }
            else
            {
                ep1.SetError(cbListe, "Il doit y avoir au moins 2 caractéres");
            }

        }
        /// <summary>
        /// When combo text is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListe_TextChanged(object sender, EventArgs e)
        {
            string text = cbListe.Text;
            int taille = text.Length;
            if (taille <= 1)
            {
                ep1.SetError(cbListe, "Il doit y avoir au moins 2 caractéres");
            }
            else
            {
                ep1.Clear();
            }
        }
        /// <summary>
        /// When you leave combo text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListe_Leave(object sender, EventArgs e)
        {
            ep1.Clear();
        }
        /// <summary>
        /// When you  enter in combo text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListe_Enter(object sender, EventArgs e)
        {
            string text = cbListe.Text;
            int taille = text.Length;
            if (taille <= 1)
            {
                ep1.SetError(cbListe, "Il doit y avoir au moins 2 caractéres");
            }
        }
        /// <summary>
        /// When you select an item in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDroite.Enabled = true;
        }
    }
}

