using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppRechercheLigne
{
    public partial class Liste : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCde;
        private SqlDataReader sqlRdr;

        public Liste()
        {
            InitializeComponent();
            cbFournisseur.Items.Add("Tous");
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source=SYLVAIN\\SQLEXPRESS;Initial Catalog=Papyrus;Integrated Security=True";
            try
            {
                sqlConnect.Open();
                sqlCde = new SqlCommand();
                sqlCde.Connection = sqlConnect;
                string strSql = "Select fournisseur_nom from fournisseur";
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = strSql;
                sqlRdr = sqlCde.ExecuteReader();
                while (sqlRdr.Read())
                {
                    cbFournisseur.Items.Add(sqlRdr["fournisseur_nom"].ToString());
                }
                sqlRdr.Close();
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
        private void cbFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFournisseur.Items.Clear();
            ;
            lbFournisseur.Visible = true;

            try
            {
                sqlConnect.Open();
                sqlCde = new SqlCommand();
                sqlCde.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                sqlCodeFournisseur.Value = cbFournisseur.Text;
                sqlCde.Parameters.Add(sqlCodeFournisseur);


                string strSql = "select * from commande  " +
                    "inner join ordre_commande  " +
                    "on commande.commande_id = ordre_commande.commande_id " +
                    "inner join produits  " +
                    "on ordre_commande.produits_id = produits.produits_id " +
                    "inner join fournisseur " +
                    "on produits.fournisseur_id = fournisseur.fournisseur_id " +
                    "where fournisseur_nom =@nomFournisseur";
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = strSql;
                sqlRdr = sqlCde.ExecuteReader();
                sqlRdr.Read();
                if (sqlRdr.HasRows)

                {
                    lbFournisseur.Items.Add(sqlRdr.GetValue(0).ToString());
                    lbFournisseur.Items.Add(sqlRdr.GetDateTime(1).ToString("d"));
                    lbFournisseur.Items.Add(sqlRdr.GetString(2));
                }
                   
                



                sqlRdr.Close();

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


