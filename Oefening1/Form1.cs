namespace Oefening1
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
            }
            else if (e.KeyCode == Keys.G && e.Modifiers == Keys.Control)
            {
                tbText.ForeColor = System.Drawing.Color.Green;
            }
            else if (e.KeyCode == Keys.B && e.Modifiers == Keys.Control)
            {
                tbText.ForeColor = System.Drawing.Color.Blue;
            }
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 7);
            }
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 9);
            }
            else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                tbText.Font = new Font("Segoe UI", 14);
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Blue;
        }



        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 14);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 9);
        }
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font("Segoe UI", 7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Red;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Blue;
        }

        private void BackgroundColorGreen_Click(object sender, EventArgs e)
        {
            tbText.BackColor = System.Drawing.Color.Green;
        }

        private void ColorRed_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Red;
        }

        private void ColorGreen_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Green;
        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = System.Drawing.Color.Blue;
        }
    }
}