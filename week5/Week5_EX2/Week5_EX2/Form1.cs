using System.Drawing.Drawing2D;

namespace Week5_EX2
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Graphics g;
        Rectangle r;
        Pen pen = new Pen(Color.Black, 5);


        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            r = new Rectangle(pictureBox1.Width / 3 +20, pictureBox1.Height / 2 -100, 200, 100, pictureBox1, this);
            pen.Alignment = PenAlignment.Inset;
            g.DrawRectangle(pen, r.r);

            pictureBox1.Image = b;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pen.Alignment = PenAlignment.Inset;
            g.DrawRectangle(pen, r.r);

            pictureBox1.Image = b;
        }
    }
}