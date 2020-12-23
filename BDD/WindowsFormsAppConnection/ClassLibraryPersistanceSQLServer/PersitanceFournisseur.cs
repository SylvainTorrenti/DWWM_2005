using System.Data.SqlClient;

namespace ClassLibraryPersistanceSQLServer
{
    public class PersitanceFournisseur
    {
        SqlConnection SqlConnection;

        public PersitanceFournisseur(string _connectionString)
        {
            SqlConnection = new SqlConnection();
            SqlConnection.ConnectionString = _connectionString;
        }

        public void Open()
        {
            SqlConnection.Open();
        }
        public void Close()
        {
            SqlConnection.Close();
        }

    }
}
