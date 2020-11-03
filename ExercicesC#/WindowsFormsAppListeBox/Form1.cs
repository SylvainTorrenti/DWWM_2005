using ClassLibraryVerification;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppListeBox
{
    public partial class ListeBox : Form
    {
        public ListeBox()
        {
            InitializeComponent();
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            lbNom.Items.Add(tbInput.Text);
            tbInput.Clear();
            tbIC.Text = lbNom.Items.Count.ToString();
            bAjouter.Enabled = false;
            tbIndex.Enabled = true;
            bEffacer.Enabled = true;
            epInput.Clear();
        }
        private void bEffacer_Click(object sender, EventArgs e)
        {
            bAjouter.Enabled = false;
            lbNom.Items.Clear();
            tbIC.Clear();
            tbIndex.Clear();
            tbInput.Clear();
            tbIndex.Clear();
            bSelect.Enabled = false;
            tbIndex.Enabled = false;
            epInput.Clear();
            epNom.Clear();
            epSI.Clear();
            tbIndex.Clear();
            tbSI.Clear();
            tbText.Clear();
            bEffacer.Enabled = false;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            bool nomValide = Verification.ValidNom(tbInput.Text);
            bool doublon = lbNom.Items.Contains(tbInput.Text);
            if (nomValide == true & doublon == false)
            {
                bAjouter.Enabled = true;
                epInput.Clear();
            }
            else if (nomValide == false)
            {
                epInput.SetError(tbInput, "Le nom n'est pas valide.");
                bAjouter.Enabled = false;
            }
            else
            {
                epInput.SetError(tbInput, "Le nom est en double.");
            }
        }
        private void bSelect_Click(object sender, EventArgs e)
        {
            int nombre = int.Parse(tbIndex.Text);
            lbNom.SetSelected(nombre - 1, true);
            tbSI.Text = Convert.ToString(nombre);
            tbText.Text = lbNom.SelectedItem.ToString();
        }

        private void tbIndex_TextChanged(object sender, EventArgs e)
        {
            bool NombreIsOk = Verification.ValidNombre(tbIndex.Text);
            if (NombreIsOk == true)
            {
                int nombre = int.Parse(tbIndex.Text);


                if (nombre > lbNom.Items.Count)
                {
                    epSI.SetError(tbIndex, "Il n'y a pas autant de références.");
                    bSelect.Enabled = false;
                }
                else if (nombre == 0)
                {
                    epSI.SetError(tbIndex, "0 n'est pas valide.");
                    bSelect.Enabled = false;
                }
                else
                {
                    bSelect.Enabled = true;
                    epSI.Clear();

                }
            }
            else
            {
                epSI.SetError(tbIndex, "Les caractére speciaux/lettres ne sont pas autorisés.");
            }

        }
        private void lbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNom.SelectedIndex == -1)
            {
                epNom.SetError(lbNom, "Il ne faut pas cliquer dans le vide");
            }
            else
            {
                tbSI.Text = Convert.ToString(lbNom.SelectedIndex + 1);
                tbText.Text = lbNom.SelectedItem.ToString();
                epNom.Clear();
            }

        }


    }

}
