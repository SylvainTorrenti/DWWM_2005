using ClassLibraryFacture;
using ClassLibraryVerification;
using System;
using System.Media;
using System.Windows.Forms;

namespace ConsoleAppValidationDeSaisie
{
    public partial class LesControle : Form
    {
        public LesControle()
        {
            InitializeComponent();
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;

        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            if (tbNom.Text.Length > 0)
            {
                buttonValider.Enabled = true;
            }
            else
            {
                buttonValider.Enabled = false;
            }

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            if (!Verification.ValidDate(tbDate.Text))
            {
                if (tbDate.TextLength < 1)
                {
                    controlErrorProvider.SetError(tbDate, "Champ obligatoire");
                }
                else
                {
                    controlErrorProvider.SetError(tbDate, "Format de date invalide");
                    SystemSounds.Exclamation.Play();
                }
            }
            else if (DateTime.Parse(tbDate.Text) <= DateTime.Now)
            {
                controlErrorProvider.SetError(tbDate, "La date doit être postérieure à aujourd'hui ");
                SystemSounds.Exclamation.Play();
            }
        }

        private void tbMontant_TextChanged(object sender, EventArgs e)
        {
            if (tbMontant.Text.Length > 0)
            {
                buttonValider.Enabled = true;
            }
            else
            {
                buttonValider.Enabled = false;
            }

        }

        private void tbCP_TextChanged(object sender, EventArgs e)
        {
            if (tbCP.Text.Length > 0)
            {
                buttonValider.Enabled = true;
            }
            else
            {
                buttonValider.Enabled = false;
            }

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string textnom = tbNom.Text;
            string textdate = tbDate.Text;
            string textmontant = tbMontant.Text;
            string textcp = tbCP.Text;

            bool nomIsOk = Verification.ValidNom(textnom);
            bool montantIsOk = Verification.ValidMontant(textmontant);
            bool cpIsOk = Verification.ValidCP(textcp);
            bool dateIsOk = Verification.ValidDate(textdate);

            string validOut = "Nom :  " + textnom + "\nDate :   " + textdate + "\nMontant :   " + textmontant.ToString() + "\nCP :   " + textcp.ToString();

            if (nomIsOk & montantIsOk & dateIsOk & cpIsOk)
            {
                MessageBox.Show(validOut, "Validation éffectuée");
                new Facture(textnom, DateTime.Parse(textdate), float.Parse(textmontant), textcp);
            }

        }



        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbDate.Clear();
            tbMontant.Clear();
            tbCP.Clear();
        }

        private void LesControle_Load(object sender, EventArgs e)
        {

        }

    }
}
