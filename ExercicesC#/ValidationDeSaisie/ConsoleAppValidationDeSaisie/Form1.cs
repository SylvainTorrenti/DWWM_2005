using System;
using System.Text.RegularExpressions;
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
            TextBox input = (TextBox)sender;
            // if ClassVerifications.VerifName(this.nameInput.Text)
            Regex regexName = new Regex(@"^{a-Zz-A}*30$");
            if (!regexName.IsMatch(this.tbNom.Text))
            {
                // TO DO 
                
            }

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*2{/}{0-9}*2{/}{0$-9}*4$");
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }

        }

        private void tbMontant_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*5");
            //check with parse
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }

        }

        private void tbCP_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*5$");
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string message = "Nom : " + tbNom.Text + "\n" + "Date : " + tbDate.Text + "\n" + "Montant : " + tbMontant.Text + "\n" + "Code : " + tbCP.Text;
            MessageBox.Show(message, "Validation saisie", MessageBoxButtons.OK);
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbDate.Clear();
            tbMontant.Clear();
            tbCP.Clear();
        }
    }
}
