using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppConnection
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private SqlConnection connexion;

        private void bConnexion_Click(object sender, EventArgs e)
        {
            connexion = new SqlConnection();
            connexion.ConnectionString = "Data Source=" + tbServeur.Text + ";Initial Catalog =" + tbBDD.Text + "; Integrated Security = True";
            try
            {
                connexion.Open();
                lConnexion.Text = "Open";
                tbErreur.Visible = false;

            }
            catch (Exception exc)
            {
                tbErreur.Visible = true;
                tbErreur.Text = exc.Message;
            }



        }

        private void bDeconnexion_Click(object sender, EventArgs e)
        {
            connexion.Close();
            lConnexion.Text = "Closed";
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



