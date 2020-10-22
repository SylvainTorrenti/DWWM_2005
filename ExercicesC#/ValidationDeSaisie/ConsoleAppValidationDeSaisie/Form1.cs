using ClassLibraryFacture;
using ClassLibraryVerification;
using System;
using System.Windows.Forms;

namespace ConsoleAppValidationDeSaisie
{
    public partial class LesControle : Form
    {
        Facture factureActuelle;
        public LesControle()
        {
            factureActuelle = new Facture();
            InitializeComponent();
        }
        public LesControle(Facture facture)
        {
            InitializeComponent();
            factureActuelle = facture;
            tbNom.Text = factureActuelle.Nom;
            tbDate.Text = factureActuelle.Date.ToString("dd/MM/yyyy");
            tbMontant.Text = factureActuelle.Montant.ToString();
            tbCP.Text = factureActuelle.CodePostal;
            this.buttonValider.Text = "Modifier";
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (tbNom.Text.Length > 0 & tbDate.Text.Length > 0 & tbMontant.Text.Length > 0 & tbCP.Text.Length > 0)
            {
                buttonValider.Enabled = true;
            }
            else
            {
                buttonValider.Enabled = false;
            }
            errorProvider.Clear();

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

            if (cpIsOk == false)
            {
                errorProvider.SetError(tbCP, "Erreur de saisie! Doit être au format '*****'");
                Verification.ErreurSaisie(tbCP);
            }
            if (montantIsOk == false)
            {
                errorProvider.SetError(tbMontant, "Erreur de saisie.");
                Verification.ErreurSaisie(tbMontant);
            }
            if (dateIsOk == false)
            {
                errorProvider.SetError(tbDate, "Erreur dans la date! Doit être au format (jj/mm/AAAA)");
                Verification.ErreurSaisie(tbDate);
            }
            if (nomIsOk == false)
            {
                errorProvider.SetError(tbNom, "Le nom n'est pas valable.");
                Verification.ErreurSaisie(tbNom);
            }


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
            errorProvider.Clear();
        }
        private void LesControle_Load(object sender, EventArgs e)
        {

        }

    }
}
