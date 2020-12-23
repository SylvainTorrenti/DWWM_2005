using System;
using System.Configuration;
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
            sqlConnect = new SqlConnection();
            ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["BD"];
            if (config != null)
            {
                sqlConnect.ConnectionString = config.ConnectionString;
            }

            try
            {
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = tbFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);

                int id = Int32.Parse(sqlCodeFournisseur.Value.ToString());

                string strSql = "Select * from fournisseur where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();


                if (sqlReader.Read() && ((int)sqlReader["fournisseur_id"]).Equals(id))
                {
                    string nomFournisseur = sqlReader["fournisseur_nom"].ToString();
                    string adresseFournisseur = sqlReader["fournisseur_adresse"].ToString();
                    string cpFournisseur = sqlReader["fournisseur_cp"].ToString();
                    string villeFournisseur = sqlReader["fournisseur_ville"].ToString();
                    string contactFournisseur = sqlReader["fournisseur_contact"].ToString();
                    byte satisfactionFournisseur = sqlReader.GetByte(6);


                        fournisseur fournisseur = new fournisseur(nomFournisseur, adresseFournisseur, cpFournisseur, villeFournisseur, contactFournisseur, satisfactionFournisseur);
                        fournisseur.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("La boite ne marche pas autant!");
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
