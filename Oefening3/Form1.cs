namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gObject = Form1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);
            gObject.FillRectangle(red, 10, 10, 100, 50);
            gObject.DrawRectangle(redPen, 10, 75, 100, 50);
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}