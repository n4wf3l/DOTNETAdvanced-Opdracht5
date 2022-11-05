using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Oefening3
{
    public partial class Form1 : Form
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        Graphics graf;

        public Form1()
        {
            InitializeComponent();
            graf = this.CreateGraphics();
        }

        Pen red = new Pen(Color.Red);
        Pen green = new Pen(Color.Green);

        public static int teller;

        private void rechthoekToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {




        int counter = teller;
            for (int i = 0; i < teller; i++)
            {
                counter--;
            }
            teller++;
            for (int i = 0; i < teller; i++)
            {
                Rectangle rect = new Rectangle(20, 20, 220, 90);
                Rectangle circle = new Rectangle(20, 20, 220, 90);
                rectangles.Add(rect);
                rectangles.Add(circle);
            }

            foreach (Rectangle rec in rectangles)
            {

                Pen pen = new Pen(Color.Red);
                graf.DrawRectangle(pen, new Rectangle(200, 200, 220, 90));
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

        }

        private void rechthoekVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graf.Clear(Color.White);
            rectangles.RemoveAt(rectangles.Count - 1);

            foreach (Rectangle r in rectangles)
            {
                Graphics graph = this.CreateGraphics();
                Pen pen = new Pen(Color.Red);
                graph.DrawRectangle(pen, new Rectangle(200, 200, 220, 90));
            }
        }
    } 
}