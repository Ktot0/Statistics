using Microsoft.VisualBasic.FileIO;
using System.Net.Sockets;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Week5_EX1
{
    public partial class Form1 : Form
    {
        EditableRectangle r;
        EditableRectangle r2;
        Bitmap b;
        Graphics g;
        Dictionary<string, int> map = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

        }

        public List<Student> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(",")
                        select new Student
                        {
                            Name = data[0],
                            Grade = int.Parse(data[1])
                        };
            return query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadCSV(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.csv");
            string rows = dataGridView1.Rows.Count.ToString();
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string key = row.Cells[1].Value.ToString();
                if (map.ContainsKey(key))
                {
                    map[key]++;
                }
                else
                {
                    map.Add(key, 1);
                }
            }
            Debug.WriteLine("Map Done");
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            Debug.WriteLine("Graphics done");
            r = new EditableRectangle(20, 20, pictureBox1.Width / 2, pictureBox1.Height / 2, pictureBox1, this);
            r2 = new EditableRectangle((pictureBox1.Width / 2) + 20, (pictureBox1.Height / 2) + 20, (pictureBox1.Width / 2) - 50, (pictureBox1.Height / 2) - 50, pictureBox1, this);
            Debug.WriteLine("Timer Start");
            timer1.Start();
        }
   

        private void drawHistogram_horizontal()
        {

            g.FillRectangle(Brushes.White, r.r);
            g.DrawRectangle(Pens.Black, r.r);

            int maxvalue = map.Values.Max();

            int space_height = r.r.Bottom - r.r.Top - 20;
            int space_width = r.r.Right - r.r.Left - 20;

            int num_intervals = map.Keys.Count;
            int histrect_width = space_width / num_intervals;

            int start = r.r.X;

            foreach (KeyValuePair<String, int> k in map)
            {
                int rect_height = (int)(((double)k.Value / (double)maxvalue) * ((double)space_height));
                Rectangle hist_rect = new Rectangle(start, r.r.Bottom - rect_height, histrect_width, rect_height);

                g.FillRectangle(Brushes.Red, hist_rect);
                g.DrawRectangle(Pens.Black, hist_rect);

                string text = k.Key;
                Rectangle stringPos = new Rectangle(start, r.r.Bottom + 20, histrect_width, histrect_width + 20);
                Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font goodFont = findFont(g, text, stringPos.Size, font1);

                g.DrawString(text, goodFont, Brushes.Black, stringPos, stringFormat);

                start += histrect_width;
            }

            pictureBox1.Image = b;
        }

        private void drawHistogram_vertical()
        {

            g.FillRectangle(Brushes.White, r2.r);
            g.DrawRectangle(Pens.Black, r2.r);

            int maxvalue = map.Values.Max();

            int space_height = r2.r.Bottom - r2.r.Top - 20;
            int space_width = r2.r.Right - r2.r.Left - 20;

            int num_intervals = map.Keys.Count;
            int histrect_width = space_height / num_intervals;

            int start = r2.r.Y;

            foreach (KeyValuePair<String, int> k in map)
            {
                int rect_height = (int)(((double)k.Value / (double)maxvalue) * ((double)space_width));
                Rectangle hist_rect = new Rectangle(r2.r.Left, start, rect_height, histrect_width);

                g.FillRectangle(Brushes.Red, hist_rect);
                g.DrawRectangle(Pens.Black, hist_rect);

                string text = k.Key;
                Rectangle stringPos = new Rectangle(r2.r.Left - (histrect_width * 7 + 10), start, histrect_width * 7, histrect_width);
                Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font goodFont = findFont(g, text, stringPos.Size, font1);

                g.DrawString(text, goodFont, Brushes.Black, stringPos, stringFormat);

                start += histrect_width;
            }

            pictureBox1.Image = b;
        }

        private Font findFont(Graphics g, string myString, Size Room, Font PreferedFont)
        {
            SizeF RealSize = g.MeasureString(myString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;

            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;

            float ScaleFontSize = PreferedFont.Size * ScaleRatio;

            return new Font(PreferedFont.FontFamily, ScaleFontSize / 3);
        }

        public class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            if (checkBox1.Checked == false)
                drawHistogram_horizontal();
            else
                drawHistogram_vertical();
        }
    }
}