using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int resizeX(double X, double minX, double maxX, int left, int W)
        {
            if ((maxX - minX) == 0)
            {
                return 0;
            }
            int res = (int)((int)left + W * (X - minX) / (maxX - minX));
            return res;
        }
        private int resizeY(double Y, double minY, double maxY, int top, int H)
        {
            if ((maxY - minY) == 0)
            {
                return 0;
            }
            int res = (int)((int)top + H - H * (Y - minY) / (maxY - minY));
            return res;
        }

        Bitmap bmp;
        Bitmap bmp2;
        Graphics g;
        Graphics g2;
        Random r = new Random();
        Pen p = new Pen(Brushes.Gray);
        Pen p2 = new Pen(Brushes.Green);
        Pen p3 = new Pen(Brushes.Red);
        Pen p4 = new Pen(Brushes.RoyalBlue);

        int probability = 50;
        int TrialsCount = 100;
        int Trajectories = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            bmp2 = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            g2 = Graphics.FromImage(bmp2);
            g2.Clear(Color.White);

            double minX = 0;
            double minY = 0;

            double maxX = TrialsCount;
            double maxY = TrialsCount;

            Rectangle VirtualWindow = new Rectangle(20, 20, bmp.Width - 40, bmp.Height - 40);
            g.DrawRectangle(p, VirtualWindow);

            Rectangle VirtualWindow2 = new Rectangle(20, 20, bmp2.Width - 40, bmp2.Height - 40);
            g2.DrawRectangle(p, VirtualWindow2);

            List<Point> Final_Point = new List<Point>();
            for (int i = 1; i <= Trajectories; i++)
            {
                List<Point> Absolute_Frequency = new List<Point>();
                int success = 0;
                for (int j = 0; j < TrialsCount; j++)
                {
                    int uniform = r.Next(100);
                    if (uniform <= probability)
                    {
                        success++;
                    }
                    int xAbsoluteDevice = resizeX(j, minX, maxX, VirtualWindow.Left, VirtualWindow.Width);
                    int yAbsoluteDevice = resizeY(success, minY, maxY, VirtualWindow.Top, VirtualWindow.Height);
                    Absolute_Frequency.Add(new Point(xAbsoluteDevice, yAbsoluteDevice));
                    if (j == TrialsCount - 1)
                    {
                        Final_Point.Add(new Point(xAbsoluteDevice, yAbsoluteDevice));
                    }
                }
                g.DrawLines(p2, Absolute_Frequency.ToArray());
            }
            Dictionary<Point, int> Histograms = new Dictionary<Point, int>();

            foreach (Point punto in Final_Point)
            {
                bool interval = false;
                foreach (KeyValuePair<Point, int> pair in Histograms)
                {
                    int v = Math.Abs(punto.Y - pair.Key.Y);
                    if (v <= 5)
                    {
                        Histograms[pair.Key] += 5;
                        interval = true;
                        break;
                    }
                }
                if (interval == false)
                {
                    Histograms.Add(punto, 5);
                }

            }
            foreach (KeyValuePair<Point, int> histogram in Histograms)
            {
                int Y = histogram.Value;
                if (Y > VirtualWindow2.Width)
                {
                    Y = VirtualWindow2.Width;
                }
                Rectangle istogramma = new Rectangle(VirtualWindow2.Left, histogram.Key.Y, Y, 5);
                g2.FillRectangle(Brushes.Green, istogramma);
                g2.DrawRectangle(p, istogramma);

            }
            this.pictureBox1.Image = bmp;
            this.pictureBox2.Image = bmp2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            bmp2 = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            g2 = Graphics.FromImage(bmp2);
            g2.Clear(Color.White);

            double minX = 0;
            double minY = 0;

            double maxX = TrialsCount;
            double maxY = TrialsCount;

            Rectangle VirtualWindow = new Rectangle(20, 20, bmp.Width - 40, bmp.Height - 40);
            g.DrawRectangle(p, VirtualWindow);

            Rectangle VirtualWindow2 = new Rectangle(20, 20, bmp2.Width - 40, bmp2.Height - 40);
            g2.DrawRectangle(p, VirtualWindow2);

            List<Point> Final_Point = new List<Point>();
            for (int i = 1; i <= Trajectories; i++)
            {
                List<Point> Relative_Frequency = new List<Point>();
                int success = 0;
                for (int j = 0; j < TrialsCount; j++)
                {
                    int uniform = r.Next(100);
                    if (uniform <= probability)
                    {
                        success++;
                    }
                    double Y = success * TrialsCount / (j + 1);
                    int xRelativeDevice = resizeX(j, minX, maxX, VirtualWindow.Left, VirtualWindow.Width);
                    int yRelativeDevice = resizeY(Y, minY, maxY, VirtualWindow.Top, VirtualWindow.Height);
                    Relative_Frequency.Add(new Point(xRelativeDevice, yRelativeDevice));

                    if (j == TrialsCount - 1)
                    {
                        Final_Point.Add(new Point(xRelativeDevice, yRelativeDevice));
                    }
                }
                g.DrawLines(p3, Relative_Frequency.ToArray());
            }
            Dictionary<Point, int> Histograms = new Dictionary<Point, int>();

            foreach (Point punto in Final_Point)
            {
                bool interval = false;
                foreach (KeyValuePair<Point, int> pair in Histograms)
                {
                    int v = Math.Abs(punto.Y - pair.Key.Y);
                    if (v <= 5)
                    {
                        Histograms[pair.Key] += 5;
                        interval = true;
                        break;
                    }
                }
                if (interval == false)
                {
                    Histograms.Add(punto, 5);
                }

            }
            foreach (KeyValuePair<Point, int> histogram in Histograms)
            {
                int Y = histogram.Value;
                if (Y > VirtualWindow2.Width)
                {
                    Y = VirtualWindow2.Width;
                }
                Rectangle istogramma = new Rectangle(VirtualWindow2.Left, histogram.Key.Y, Y, 5);
                g2.FillRectangle(Brushes.Red, istogramma);
                g2.DrawRectangle(p, istogramma);

            }
            this.pictureBox1.Image = bmp;
            this.pictureBox2.Image = bmp2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            bmp2 = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            g2 = Graphics.FromImage(bmp2);
            g2.Clear(Color.White);

            double minX = 0;
            double minY = 0;

            double maxX = TrialsCount;
            double maxY = TrialsCount;

            Rectangle VirtualWindow = new Rectangle(20, 20, bmp.Width - 40, bmp.Height - 40);
            g.DrawRectangle(p, VirtualWindow);

            Rectangle VirtualWindow2 = new Rectangle(20, 20, bmp2.Width - 40, bmp2.Height - 40);
            g2.DrawRectangle(p, VirtualWindow2);

            List<Point> Final_Point = new List<Point>();
            for (int i = 1; i <= Trajectories; i++)
            {
                List<Point> Normalized_Frequency = new List<Point>();
                int success = 0;
                for (int j = 0; j < TrialsCount; j++)
                {
                    int uniform = r.Next(100);
                    if (uniform <= probability)
                    {
                        success++;
                    }
                    double nY = success * Math.Sqrt(TrialsCount) / (Math.Sqrt(j + 1));
                    int xNormalizedDevice = resizeX(j, minX, maxX, VirtualWindow.Left, VirtualWindow.Width);
                    int yNormalizedeDevice = resizeY(nY, minY, maxY, VirtualWindow.Top, VirtualWindow.Height);
                    Normalized_Frequency.Add(new Point(xNormalizedDevice, yNormalizedeDevice));

                    if (j == TrialsCount - 1)
                    {
                        Final_Point.Add(new Point(xNormalizedDevice, yNormalizedeDevice));
                    }
                }
                g.DrawLines(p4, Normalized_Frequency.ToArray());
            }
            Dictionary<Point, int> Histograms = new Dictionary<Point, int>();

            foreach (Point punto in Final_Point)
            {
                bool interval = false;
                foreach (KeyValuePair<Point, int> pair in Histograms)
                {
                    int v = Math.Abs(punto.Y - pair.Key.Y);
                    if (v <= 5)
                    {
                        Histograms[pair.Key] += 5;
                        interval = true;
                        break;
                    }
                }
                if (interval == false)
                {
                    Histograms.Add(punto, 5);
                }

            }
            foreach (KeyValuePair<Point, int> histogram in Histograms)
            {
                int Y = histogram.Value;
                if (Y > VirtualWindow2.Width)
                {
                    Y = VirtualWindow2.Width;
                }
                Rectangle istogramma = new Rectangle(VirtualWindow2.Left, histogram.Key.Y, Y, 5);
                g2.FillRectangle(Brushes.RoyalBlue, istogramma);
                g2.DrawRectangle(p, istogramma);

            }
            this.pictureBox1.Image = bmp;
            this.pictureBox2.Image = bmp2;
        }
    }
}
