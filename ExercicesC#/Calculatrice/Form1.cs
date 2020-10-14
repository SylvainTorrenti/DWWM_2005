using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Additionneur : Form
    {
        private int somme = 0;

        public Additionneur()
        {
            InitializeComponent();

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button buttonNumber = (Button)sender;
            int buttonValue = Int32.Parse(buttonNumber.Tag.ToString());
            textBoxAffichageCalcul.Text += buttonValue + "+";
            somme += buttonValue;

        }

        private void vider_Click(object sender, EventArgs e)
        {
            textBoxAffichageCalcul.Clear();
            somme = 0;
        }

        private void Calculer_Click(object sender, EventArgs e)
        {
            textBoxAffichageCalcul.Text += "=" + somme + "+";
        }

        private void Additionneur_Load(object sender, EventArgs e)
        {

        }
    }
}
