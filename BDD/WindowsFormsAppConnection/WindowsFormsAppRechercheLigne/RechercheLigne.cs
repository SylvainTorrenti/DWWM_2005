using System;
using System.Collections.Generic;
using System.Configuration;
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
        private Dictionary<string, int> dic_nom_id;
       
        public Liste()
        {
            InitializeComponent();
            cbFournisseur.Items.Add("Tous");
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["BD"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }

            try
            {
                sqlConnect.Open();
                sqlCde = new SqlCommand();
                sqlCde.Connection = sqlConnect;
                string strSql = "Select * from fournisseur";
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = strSql;
                sqlRdr = sqlCde.ExecuteReader();

                dic_nom_id = new Dictionary<string, int>();

                while (sqlRdr.Read())
                {
                    cbFournisseur.Items.Add(sqlRdr["fournisseur_nom"].ToString());
                    dic_nom_id.Add(sqlRdr["fournisseur_nom"].ToString(), (int)sqlRdr[sqlRdr.GetName(0)]);
                    
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

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.String);
                sqlCodeFournisseur.Value = dic_nom_id[cbFournisseur.Text];
                sqlCde.Parameters.Add(sqlCodeFournisseur);

                {
                    string strSql = "select * from commande  " +
                        "inner join ordre_commande  " +
                        "on commande.commande_id = ordre_commande.commande_id " +
                        "inner join produits  " +
                        "on ordre_commande.produits_id = produits.produits_id " +
                        "inner join fournisseur " +
                        "on produits.fournisseur_id = fournisseur.fournisseur_id " +
                        "where fournisseur.fournisseur_id =@codeFournisseur";
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

        public static void GetEntCom()
        {

        }
    }
}