using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryVerification
{
    public static class Verification
    {

        private const string regexNom = @"^[A-Za-z]+$";
        private const string regexCp = @"^(?:[0-8]\d|[0-8])\d{3}$";



        public static bool ValidDate(string _date)
        {
            if (_date.Length != 10)
            {
                return false;
            }
            DateTime billDate = new DateTime();
            if (!DateTime.TryParseExact(_date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out billDate))
            {
                return false;
            }
            if (!(billDate <= DateTime.Today))
            {
                return false;
            }
            return true;
        }

        public static bool ValidNom(string _nom)
        {
            return Regex.IsMatch(_nom, regexNom);

        }

        public static bool ValidMontant(string _montant)
        {

            if (float.TryParse(_montant, out float result))
            {
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool ValidCP(string _cp)
        {
            return Regex.IsMatch(_cp, regexCp);

        }
        public static void ErreurSaisie(TextBox textbox)
        {
            textbox.Focus();
            SystemSounds.Exclamation.Play();
        }

    }


}