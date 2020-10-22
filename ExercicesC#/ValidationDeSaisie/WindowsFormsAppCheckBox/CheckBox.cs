using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCheckBox
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            if (tbInput.TextLength>0)
            {
                cbCasse.Enabled = true;
                cbChar.Enabled = true;
                cbFond.Enabled = true;
                lModifier.Text = tbInput.Text;
            }
            else
            {
                cbCasse.Enabled = false;
                cbChar.Enabled = false;
                cbFond.Enabled = false;
                rdFondBleu.Visible = false;
                rdFondRouge.Visible = false;
                rdFondVert.Visible = false;
                rdCharNoir.Visible = false;
                rdCharBlanc.Visible = false;
                rdCharRouge.Visible = false;
                rdMin.Visible = false;
                rdMaj.Visible = false;
                cbCasse.Checked = false;
                cbChar.Checked = false;
                cbFond.Checked = false;
                lModifier.Text = " ";
                lModifier.BackColor = SystemColors.Control;
                lModifier.ForeColor = System.Drawing.Color.Black;

            }
        }

        private void cbFond_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFond.Checked)
            {
                rdFondBleu.Visible = true;
                rdFondRouge.Visible = true;
                rdFondVert.Visible = true;
            }
            else
            {
                rdFondBleu.Visible = false;
                rdFondRouge.Visible = false;
                rdFondVert.Visible = false;
            }
        }

        private void cbChar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChar.Checked)
            {
                rdCharNoir.Visible = true;
                rdCharBlanc.Visible = true;
                rdCharRouge.Visible = true;
            }
            else
            {
                rdCharNoir.Visible = false;
                rdCharBlanc.Visible = false;
                rdCharRouge.Visible = false;
            }
        }

        private void cbCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCasse.Checked)
            {
                rdMin.Visible = true;
                rdMaj.Visible = true;
            }
            else
            {
                rdMin.Visible = false;
                rdMaj.Visible = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void rdMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMin.Checked == true)
            {

                lModifier.Text = lModifier.Text.ToLower();
            }
            else
            {
                lModifier.Text = lModifier.Text;
            }
        }

        private void rdMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaj.Checked == true)
            {

                lModifier.Text = lModifier.Text.ToUpper();
            }
            else
            {
                lModifier.Text = lModifier.Text;
            }
        }

        private void rdCharRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCharRouge.Checked == true)
            {
                lModifier.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void rdCharBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCharBlanc.Checked == true)
            {
                lModifier.ForeColor = System.Drawing.Color.White;
            }
        }

        private void rdCharNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCharNoir.Checked == true)
            {
                lModifier.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void rdFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFondRouge.Checked == true)
            {
                lModifier.BackColor = System.Drawing.Color.Red;
            }

        }

        private void rdFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFondVert.Checked == true)
            {
                lModifier.BackColor = System.Drawing.Color.Green;
            }
        }

        private void rdFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFondBleu.Checked == true)
            {
                lModifier.BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
