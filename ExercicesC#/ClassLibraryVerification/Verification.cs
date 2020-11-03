using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryVerification
{
    public static class Verification
    {

        private const string regexNom = @"^[A-Za-z]{2,}|[-]{1}[A-Za-z]{2,}$";
        private const string regexCp = @"^(?:[0-8]\d|[0-8])\d{3}$";
        private const string regexNombre = @"^[1-9]*[0-9]*$";
        private const string regexMaj = @"^(?:[A-Z])[a-z]{2,}$";


        /// <summary>
        /// method for checking date
        /// </summary>
        /// <param name="_date"></param>
        /// <returns></returns>
        public static bool ValidDate(string _date)
        {
            if (_date.Length != 10)
            {
                return false;
            }
            DateTime factureDate = new DateTime();
            if (!DateTime.TryParseExact(_date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out factureDate))
            {
                return false;
            }
            if (factureDate <= DateTime.Today)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// method for checking name
        /// </summary>
        /// <param name="_nom"></param>
        /// <returns></returns>
        public static bool ValidNom(string _nom)
        {
            return Regex.IsMatch(_nom, regexNom);

        }
        /// <summary>
        /// method for checking ammount
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns></returns>
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
        /// <summary>
        /// method for checking postal code
        /// </summary>
        /// <param name="_cp"></param>
        /// <returns></returns>
        public static bool ValidCP(string _cp)
        {
            return Regex.IsMatch(_cp, regexCp);

        }
        /// <summary>
        /// method for do song when error pop
        /// </summary>
        /// <param name="textbox"></param>
        public static void ErreurSaisie(TextBox textbox)
        {
            textbox.Focus();
            SystemSounds.Exclamation.Play();
        }
        /// <summary>
        /// method for checking number
        /// </summary>
        /// <param name="_nombre"></param>
        /// <returns></returns>
        public static bool ValidNombre(string _nombre)
        {

            return int.TryParse(_nombre, out int result) && Regex.IsMatch(_nombre, regexNombre);
        }
    }


}