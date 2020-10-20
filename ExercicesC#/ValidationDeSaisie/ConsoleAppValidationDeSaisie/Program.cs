using ConsoleAppValidationDeSaisie;
using System.Windows.Forms;

namespace ValidationSaisies
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LesControle());
        }
    }
}