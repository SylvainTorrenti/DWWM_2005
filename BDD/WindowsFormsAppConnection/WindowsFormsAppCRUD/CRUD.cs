using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppCRUD
{
    public partial class CRUD : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        public CRUD()
        {
            InitializeComponent();
        }

        private void bRecherche_Click(object sender, EventArgs e)
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

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codefournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = tbCodeExistant.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);

                string strSql = "Select * from fournisseur where fournisseur_id =@codefournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();
                sqlReader.Read();
                if (sqlReader.HasRows == false)
                {
                    MessageBox.Show("L'ID n'est pas valide.");
                }
                else
                {
                    tbId.Text = sqlReader["fournisseur_id"].ToString();
                    tbNom.Text = sqlReader["fournisseur_nom"].ToString();
                    tbAdresse.Text = sqlReader["fournisseur_adresse"].ToString();
                    tbCP.Text = sqlReader["fournisseur_cp"].ToString();
                    tbVille.Text = sqlReader["fournisseur_ville"].ToString();
                    tbContact.Text = sqlReader["fournisseur_contact"].ToString();
                    tbSatisfaction.Text = sqlReader["fournisseur_satisfaction"].ToString();

                    lNom.Visible = true;
                    lId.Visible = true;
                    lFournisseur.Visible = true;
                    lCP.Visible = true;
                    lContact.Visible = true;
                    lAdresse.Visible = true;
                    lVille.Visible = true;
                    lStatisfaction.Visible = true;
                    tbVille.Visible = true;
                    tbSatisfaction.Visible = true;
                    tbNom.Visible = true;
                    tbId.Visible = true;
                    tbCP.Visible = true;
                    tbContact.Visible = true;
                    tbAdresse.Visible = true;
                    bDelete.Enabled = true;
                    tbCodeExistant.Clear();
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

        private void bCréé_Click(object sender, EventArgs e)
        {
            lId.Visible = false;
            tbId.Visible = false;
            tbId.Clear();
            lNom.Visible = true;
            lFournisseur.Visible = true;
            lCP.Visible = true;
            lContact.Visible = true;
            lAdresse.Visible = true;
            lVille.Visible = true;
            lStatisfaction.Visible = true;
            tbVille.Visible = true;
            tbVille.Clear();
            tbSatisfaction.Visible = true;
            tbSatisfaction.Clear();
            tbNom.Visible = true;
            tbNom.Clear();
            tbCP.Visible = true;
            tbCP.Clear();
            tbContact.Visible = true;
            tbContact.Clear();
            tbAdresse.Visible = true;
            tbAdresse.Clear();
            tbCodeExistant.Clear();
            bAjouter.Visible = true;
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAjouter_Click(object sender, EventArgs e)
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



                SqlParameter sqlNomFournisseur = new SqlParameter("@fournisseur_nom", DbType.String);
                sqlNomFournisseur.Value = tbNom.Text;

                SqlParameter sqlAdresseFournisseur = new SqlParameter("@fournisseur_adresse", DbType.String);
                sqlAdresseFournisseur.Value = tbAdresse.Text;

                SqlParameter sqlCpFournisseur = new SqlParameter("@fournisseur_cp", DbType.String);
                sqlCpFournisseur.Value = tbCP.Text;

                SqlParameter sqlVilleFournisseur = new SqlParameter("@fournisseur_ville", DbType.String);
                sqlVilleFournisseur.Value = tbVille.Text;

                SqlParameter sqlContactFournisseur = new SqlParameter("@fournisseur_contact", DbType.String);
                sqlContactFournisseur.Value = tbContact.Text;

                SqlParameter sqlSatisfactionFournisseur = new SqlParameter("@fournisseur_satisfaction", DbType.String);
                sqlSatisfactionFournisseur.Value = tbSatisfaction.Text;

                SqlParameter fIdOut = new SqlParameter("@idFournisseur", SqlDbType.Int);
                fIdOut.Direction = ParameterDirection.Output;

                sqlCommande.Parameters.Add(sqlNomFournisseur);
                sqlCommande.Parameters.Add(sqlAdresseFournisseur);
                sqlCommande.Parameters.Add(sqlCpFournisseur);
                sqlCommande.Parameters.Add(sqlVilleFournisseur);
                sqlCommande.Parameters.Add(sqlContactFournisseur);
                sqlCommande.Parameters.Add(sqlSatisfactionFournisseur);

                if (tbNom.Text == "")
                {
                    MessageBox.Show("Il faut entré un nom.");
                }
                else if (tbAdresse.Text == "")
                {
                    MessageBox.Show("Il faut entré une adresse.");
                }
                else if (tbCP.Text == "")
                {
                    MessageBox.Show("Il faut entré un Code Postal.");
                }
                else if (tbVille.Text == "")
                {
                    MessageBox.Show("Il faut entré une ville.");
                }
                else if (tbContact.Text == "")
                {
                    MessageBox.Show("Il faut entré un nom de contact.");
                }
                else if (tbSatisfaction.Text == "")
                {
                    MessageBox.Show("Il faut entré une note de satisfaction.");
                }
                else
                {
                    string strSql = "Insert into fournisseur(fournisseur_nom,fournisseur_adresse,fournisseur_cp,fournisseur_ville,fournisseur_contact,fournisseur_satisfaction) " +
                        "VALUES(@fournisseur_nom,@fournisseur_adresse,@fournisseur_cp,@fournisseur_ville,@fournisseur_contact,@fournisseur_satisfaction)";
                    sqlCommande.CommandType = CommandType.Text;
                    sqlCommande.CommandText = strSql;
 
                    int nbLign = sqlCommande.ExecuteNonQuery();
                    if (nbLign == 1)
                    {
                        MessageBox.Show("Le fournissuer " + tbNom.Text + " a était ajouté");
                        tbVille.Clear();
                        tbSatisfaction.Clear();
                        tbNom.Clear();
                        tbId.Clear();
                        tbCP.Clear();
                        tbContact.Clear();
                        tbAdresse.Clear();
                        
                    }
                }
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

        private void bDelete_Click(object sender, EventArgs e)
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
                SqlParameter sqlidFournisseur = new SqlParameter("@fournisseur_id", DbType.Int32);
                sqlidFournisseur.Value = tbId.Text;
                sqlCommande.Parameters.Add(sqlidFournisseur);
                string strSql = "DELETE FROM fournisseur WHERE fournisseur_id=@fournisseur_id";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();
                if (sqlReader.RecordsAffected > 0)
                {
                    MessageBox.Show("Le fournisseur " + tbNom.Text + " n'est plus dans notre société");
                    tbVille.Clear();
                    tbSatisfaction.Clear();
                    tbNom.Clear();
                    tbId.Clear();
                    tbCP.Clear();
                    tbContact.Clear();
                    tbAdresse.Clear();
                }
                else
                {
                    MessageBox.Show("Le fournisseur n'a pas était trouvé");
                }
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
    }
}
