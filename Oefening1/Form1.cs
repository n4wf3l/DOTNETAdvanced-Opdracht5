using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5Oefening1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            tbText.BorderStyle = BorderStyle.None;
            tbText.Cursor = Cursors.Default;
            /*tbText.ReadOnly = true;*/
            tbText.TabStop = false;
            tbText.Text = "How sharper than a serpent's tooth it is to have a buggy program";
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                tbText.ForeColor = System.Drawing.Color.Red;
            }else if(e.KeyCode == Keys.G && e.Modifiers == Keys.Control)
            {
                tbText.ForeColor = System.Drawing.Color.Green;
            }else if(e.KeyCode == Keys.B && e.Modifiers == Keys.Control)
            {
                tbText.ForeColor = System.Drawing.Color.Blue;
            }else if(e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 7);
            }else if(e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 9);
            }
            else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 14);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void redCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Red;
        }

        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Green;
        }

        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Blue;
        }

        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 14);
        }

        private void normalCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 9);
        }
        private void smallCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 7);
        }

    }
}
