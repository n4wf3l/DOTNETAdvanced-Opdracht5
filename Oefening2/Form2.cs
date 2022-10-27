using Oefening2;
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
    public partial class Form2 : Form
    {
        List<double> input = new List<double>();
        double totaal;
        double gemiddelde;


        public Form2()
        {
            InitializeComponent();
            Form1 MDIParent = new Form1();
            MDIParent.Show();
        }

        private void btNieuwGetal_Click(object sender, EventArgs e)
        {
            using (Form3 derdeForm = new Form3())
            {
                if (derdeForm.ShowDialog() == DialogResult.OK)
                {
                    lbGetal.Items.Add(derdeForm.Getal);
                    double waarde = double.Parse(derdeForm.Getal);
                    input.Add(waarde);

                    for (int i = 0; i < input.Count; i++)
                    {
                        totaal = totaal + input[i];
                    }
                    tbGemiddelde.Text = Math.Round((totaal / input.Count), 2).ToString();
                    totaal = 0;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbGemiddelde_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
