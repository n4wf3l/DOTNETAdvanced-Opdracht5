using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form3 : Form
    {
        public string Getal { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbWaarde.Text == string.Empty)
            {
                MessageBox.Show("Gelieve een cijfer in te typen.");
                tbWaarde.Text = null;

            }
            else
            {
                Getal = tbWaarde.Text;
            }
            tbWaarde.Text = null;
        }

        private void tbWaarde_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
