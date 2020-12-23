using ClassLibraryMetierProducts;
using ClassLibraryPersistanceSQLServer;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppCouche
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            Fournisseur.MaPersistance = new PersitanceFournisseur(connectionString);
            Application.Run(new Couche());
        }
    }
}
