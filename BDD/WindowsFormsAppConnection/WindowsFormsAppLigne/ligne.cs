using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppLigne
{
    public partial class Ligne : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        public Ligne()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new SqlConnection();
                sqlConnect.ConnectionString = "Data Source=SYLVAIN\\SQLEXPRESS;Initial Catalog=Papyrus;Integrated Security=True";
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codefournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = tbFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "Select * from fournisseur where fournisseur_id =@codefournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows == false)
                {
                    MessageBox.Show("La boite ne marche pas autant!");
                }

                while (sqlReader.Read())
                {
                    string nomFournisseur = sqlReader.GetString(1);
                    string adresseFournisseur = sqlReader.GetString(2);
                    string cpFournisseur = sqlReader.GetString(3);
                    string villeFournisseur = sqlReader.GetString(4);
                    string contactFournisseur = sqlReader.GetString(5);
                    byte satisfactionFournisseur = sqlReader.GetByte(6);
                    fournisseur fournisseur = new fournisseur(nomFournisseur, adresseFournisseur, cpFournisseur, villeFournisseur, contactFournisseur, satisfactionFournisseur);
                    fournisseur.ShowDialog();
                }
                sqlReader.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            this.Close();
        }

        private void Recherche_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            Close();
        }
    }
}
