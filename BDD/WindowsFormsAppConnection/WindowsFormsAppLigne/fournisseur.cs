using System.Windows.Forms;

namespace WindowsFormsAppLigne
{
    public partial class fournisseur : Form
    {
        public fournisseur()
        {
            InitializeComponent();
        }
        public fournisseur(string nom, string adresse, string cp, string ville, string contact, int satisfaction)
        {
            InitializeComponent();
            tbNom.Text = nom;
            tbAdresse.Text = adresse;
            tbCP.Text = cp;
            tbVille.Text = ville;
            tbContact.Text = contact;
            tbSatisfaction.Text = satisfaction.ToString();
        }

        private void bRetour_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
