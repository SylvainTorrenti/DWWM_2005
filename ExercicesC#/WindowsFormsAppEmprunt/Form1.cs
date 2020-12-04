using ClassLibraryVerification;
using System;
using System.Windows.Forms;
using static ClassLibraryEmprunt.Emprunt;

namespace WindowsFormsAppEmprunt
{
    public partial class Emprunt : Form
    {
        ClassLibraryEmprunt.Emprunt emprunt;
        public Emprunt()
        {
            emprunt = new ClassLibraryEmprunt.Emprunt();
            InitializeComponent();
            Array duree = Enum.GetValues(typeof(PeriodeCouranteRemboursement));
            foreach (object obj in duree)
            {
                lbEmprunt.Items.Add(obj);
            }
            lbEmprunt.SelectedIndex = 0;
            rb7.Checked = true;
            update();
        }

        private void tbNom_TextChanged(object sender, System.EventArgs e)
        {
            bool nomValide = Verification.ValidNom(tbNom.Text);
            if (nomValide != true)
            {
                ep1.SetError(tbNom, "Le nom n'est pas valide. Il faut une majuscule.");
            }
            else if (nomValide == true)
            {
                ep1.Clear();
            }

        }

        private void tbCE_TextChanged(object sender, System.EventArgs e)
        {
            string textmontant = tbCE.Text;
            bool montantValide = Verification.ValidEmprunt(textmontant);
            if (montantValide != true)
            {
                ep1.SetError(tbCE, "Le montant n'est pas valide");
                bOk.Enabled = false;
            }
            else
            {
                bOk.Enabled = true;
                emprunt.Montant = Int32.Parse(tbCE.Text);
                ep1.Clear();
            }
            update();
        }
        public void update()
        {
            if (rb7.Checked)
            {
                emprunt.Taux = 7;
            }
            if (rb8.Checked)
            {
                emprunt.Taux = 8;
            }
            if (rb9.Checked)
            {
                emprunt.Taux = 9;
            }
            switch (lbEmprunt.SelectedIndex)
            {
                case 0:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Mensuelle;

                    break;
                case 1:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Bimensuelle;

                    break;
                case 2:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Trimestrielle;

                    break;
                case 3:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Semestrielle;

                    break;
                case 4:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Annuelle;

                    break;
            }
            labelNbRemboursement.Text = emprunt.CalculMois().ToString();
            labelMontantRemboursement.Text = emprunt.Calcul().ToString();
            labelDureeModif.Text = hsEmprunt.Value.ToString();
        }

        private void hsEmprunt_Scroll(object sender, ScrollEventArgs e)
        {
            emprunt.NombreDeMois = hsEmprunt.Value;
            update();
        }
        private void lbEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = (ListBox)sender;
            switch (currentListBox.SelectedIndex)
            {
                case 0:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Mensuelle;
                    hsEmprunt.Minimum = 1;
                    hsEmprunt.Value = 1;
                    hsEmprunt.SmallChange = 1;
                    hsEmprunt.LargeChange = 1;
                    break;
                case 1:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Bimensuelle;
                    hsEmprunt.Minimum = 2;
                    hsEmprunt.Value = 2;
                    hsEmprunt.SmallChange = 2;
                    hsEmprunt.LargeChange = 2;
                    break;
                case 2:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Trimestrielle;
                    hsEmprunt.Minimum = 3;
                    hsEmprunt.Value = 3;
                    hsEmprunt.SmallChange = 3;
                    hsEmprunt.LargeChange = 3;
                    break;
                case 3:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Semestrielle;
                    hsEmprunt.Minimum = 6;
                    hsEmprunt.Value = 6;
                    hsEmprunt.SmallChange = 6;
                    hsEmprunt.LargeChange = 6;
                    break;
                case 4:
                    emprunt.RemboursementActuel = PeriodeCouranteRemboursement.Annuelle;
                    hsEmprunt.Minimum = 12;
                    hsEmprunt.Value = 12;
                    hsEmprunt.SmallChange = 12;
                    hsEmprunt.LargeChange = 12;
                    break;
            }
            update();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
