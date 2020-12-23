using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppConnection
{
    public partial class Connexion : Form
    {
        private SqlConnection sqlConnect;

        public Connexion()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection();
            ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["BD"];
            
                try
                {


                    sqlConnect.Open();
                    tbErreur.Visible = false;
                    tbErreur.Clear();
                    bConnexion.Enabled = false;
                    bDeconnexion.Enabled = true;
                }
                catch (SqlException se)
                {
                    tbErreur.Visible = true;
                    for (int i = 0; i < se.Errors.Count; i++)
                    {
                        tbErreur.Text += "ERROR#" + i + "\n" +
                            "Message: " + se.Errors[i].Message + "\n" +
                            "Error Code: " + se.ErrorCode + "\n" +
                            "Error Number: " + se.Errors[i].Number + "\n";
                    }
                }
                lConnexion.Text = sqlConnect.State.ToString();
            }
        



        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            lConnexion.Text = sqlConnect.State.ToString();
            bConnexion.Enabled = true;
            bDeconnexion.Enabled = false;

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaisieConnexion()
        {
            string dataSource = tbServeur.Text;
            string dataBase = tbBDD.Text;
            if (dataSource.Length > 0 && dataBase.Length > 0)
            {
                sqlConnect = new SqlConnection();

                sqlConnect.ConnectionString = "Data Source = " + dataSource + "; Initial Catalog = " + dataBase + "; Integrated Security = True";
                tbServeur.Text = sqlConnect.DataSource;
                tbBDD.Text = sqlConnect.Database;
            }

        }

        private void textBoxServeur_TextChanged(object sender, EventArgs e)
        {
            this.SaisieConnexion();
        }

        private void textBoxBdd_TextChanged(object sender, EventArgs e)
        {
            this.SaisieConnexion();

        }
    }
}



