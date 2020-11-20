using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDefilement
{
    public partial class Defilement : Form
    {

        private System.Drawing.Color couleur;
 
        public Defilement()
        {
            InitializeComponent();
            couleur = Color.FromArgb(0, 0, 0);
            MettreAJourLIhm();
        }
        public Defilement(Color _couleur)
        {
            InitializeComponent();
            couleur = _couleur;
            MettreAJourLIhm();
        }       
        public void MettreAJourLIhm()
        {
            hSRouge.Value = couleur.R;
            UPRouge.Value = couleur.R;
            tbRouge.BackColor = Color.FromArgb(couleur.R, 0, 0);

            hSVert.Value = couleur.G;
            UPVert.Value = couleur.G;
            tbVert.BackColor = Color.FromArgb(0, couleur.G, 0);

            hSBleu.Value = couleur.B;
            UPBleu.Value = couleur.B;
            tbBleu.BackColor = Color.FromArgb(0, 0, couleur.B);

            tbFinale.BackColor = couleur;
        }
        private void UPRouge_ValueChanged(object sender, EventArgs e)
        {
            couleur = Color.FromArgb((int)UPRouge.Value, couleur.G, couleur.B);
            MettreAJourLIhm();

        }

        private void UPVert_ValueChanged(object sender, EventArgs e)
        {           
            couleur = Color.FromArgb(couleur.R, (int)UPVert.Value, couleur.B);
            MettreAJourLIhm();
        }

        private void UPBleu_ValueChanged(object sender, EventArgs e)
        {
            couleur = Color.FromArgb(couleur.R, couleur.G, (int)UPBleu.Value);
            MettreAJourLIhm();
        }

        private void hSRouge_Scroll(object sender, ScrollEventArgs e)
        {
            couleur = Color.FromArgb(hSRouge.Value, couleur.G, couleur.B);
            MettreAJourLIhm();
        }

        private void hSVert_Scroll(object sender, ScrollEventArgs e)
        {
            couleur = Color.FromArgb(couleur.R, hSVert.Value, couleur.B);
            MettreAJourLIhm();
        }

        private void hSBleu_Scroll(object sender, ScrollEventArgs e)
        {
            couleur = Color.FromArgb(couleur.R, couleur.G, hSBleu.Value);
            MettreAJourLIhm();
        }

    }
}
