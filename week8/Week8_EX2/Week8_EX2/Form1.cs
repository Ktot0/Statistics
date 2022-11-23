namespace Week8_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGraphics();
        }

        Bitmap b;
        Graphics g;
        EditableRectangle r1;
        EditableRectangle r2;
        EditableRectangle r3;
        EditableRectangle r4;
        EditableRectangle r5;

        List<double> normal;
        Dictionary<CreateInterval, int> normal_distribution;

        List<double> chisquared;
        Dictionary<CreateInterval, int> chisquared_distribution;

        List<double> cauchy;
        Dictionary<CreateInterval, int> cauchy_distribution;

        List<double> Ffisher;
        Dictionary<CreateInterval, int> Ffisher_distribution;

        List<double> Tstudent;
        Dictionary<CreateInterval, int> Tstudent_distribution;

        int numbersamples = 100000;

        private void InitializeGraphics()
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            r1 = new EditableRectangle(b.Width / 4, pictureBox1.Bottom / 4, b.Width / 4 + 500, b.Height / 2 + 100, pictureBox1, this);
            r2 = new EditableRectangle(b.Width / 4, pictureBox1.Bottom / 4, b.Width / 4 + 500, b.Height / 2 + 100, pictureBox1, this);
            r3 = new EditableRectangle(b.Width / 4, pictureBox1.Bottom / 4, b.Width / 4 + 500, b.Height / 2 + 100, pictureBox1, this);
            r4 = new EditableRectangle(b.Width / 4, pictureBox1.Bottom / 4, b.Width / 4 + 500, b.Height / 2 + 100, pictureBox1, this);
            r5 = new EditableRectangle(b.Width / 4, pictureBox1.Bottom / 4, b.Width / 4 + 500, b.Height / 2 + 100, pictureBox1, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            GenerateNormalRV RVgen = new GenerateNormalRV();

            normal = new List<double>();


            for (int i = 0; i < numbersamples; i++)
            {
                (double X, double Y) = RVgen.getNewPair();

                normal.Add(X);
            }


            normal_distribution = compute_distribution(normal, 0.2d);

            timer1.Start();

        }

        private Dictionary<CreateInterval, int> compute_distribution(List<double> lista, double interval_size)
        {
            Dictionary<CreateInterval, int> distribution = new Dictionary<CreateInterval, int>();
            double next = Math.Floor(lista.Min());

            foreach (double inter in lista)
            {
                bool inserted = false;

                List<CreateInterval> keys = distribution.Keys.ToList();
                foreach (CreateInterval v in keys)
                {
                    if (inter >= v.down && inter < v.up)
                    {
                        inserted = true;
                        distribution[v]++;
                    }
                }
                while (!inserted)
                {
                    CreateInterval newint = new CreateInterval(next, next + interval_size);
                    next = next + interval_size;
                    distribution[newint] = 0;

                    if (inter >= newint.down && inter < newint.up)
                    {
                        distribution[newint]++;
                        inserted = true;
                    }
                }
            }

            return distribution;
        }

        private void drawHistogram(Dictionary<CreateInterval, int> distribution, EditableRectangle r, Graphics g, string text)
        {
            g.DrawRectangle(Pens.Gray, r.r);
            g.FillRectangle(Brushes.Black, r.r);

            int maxvalue = distribution.Values.Max();
            int space_height = (r.r.Bottom - r.r.Top) - 20;

            int size = r.r.Width / distribution.Count;
            int X = r.r.Left;

            foreach (KeyValuePair<CreateInterval, int> kv in distribution)
            {

                CreateInterval i = kv.Key;

                int rect_height = (int)(((double)kv.Value / (double)maxvalue) * ((double)space_height));

                Rectangle histrect = new Rectangle(X, r.r.Bottom - rect_height, size, rect_height);
                g.FillRectangle(Brushes.RoyalBlue, histrect);
                g.DrawRectangle(Pens.Black, histrect);

                X = X + size;
            }

            Rectangle stringPos = new Rectangle(r.r.Left, r.r.Top - 2 * (r.r.Height / 5), r.r.Width, r.r.Height / 5);
            Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Font goodFont = findFont(g, text, stringPos.Size, font1);

            g.DrawString(text, goodFont, Brushes.Black, stringPos, stringFormat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawHistogram(normal_distribution, r1, g, "Normal");
            pictureBox1.Image = b;
        }

        private Font findFont(Graphics g, string myString, Size Room, Font PreferedFont)
        {
            SizeF RealSize = g.MeasureString(myString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;

            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;

            float ScaleFontSize = PreferedFont.Size * ScaleRatio;

            if (ScaleFontSize <= 0)
            {
                ScaleFontSize = 0.0000001f;
            }

            return new Font(PreferedFont.FontFamily, ScaleFontSize / 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();


            GenerateNormalRV RVgen = new GenerateNormalRV();

            chisquared = new List<double>();

            for (int i = 0; i < numbersamples; i++)
            {
                (double X, double Y) = RVgen.getNewPair();
                chisquared.Add(X * X);
            }

            chisquared_distribution = compute_distribution(chisquared, 0.6d);
            timer2.Start();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            GenerateNormalRV RVgen = new GenerateNormalRV();
            cauchy = new List<double>();


            for (int i = 0; i < numbersamples; i++)
            {
                (double X, double Y) = RVgen.getNewPair();

                cauchy.Add(X / Y);

            }

            double cauchy_average = cauchy.Average();
            cauchy = cauchy.Where(x => (x >= cauchy_average - 50 && x <= cauchy_average + 50)).ToList();

            cauchy_distribution = compute_distribution(cauchy, 5);

            timer3.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            GenerateNormalRV RVgen = new GenerateNormalRV();

            Ffisher = new List<double>();


            for (int i = 0; i < numbersamples; i++)
            {
                (double X, double Y) = RVgen.getNewPair();

                Ffisher.Add((X * X) / (Y * Y));

            }


            Ffisher = Ffisher.Where(x => (x <= 50)).ToList();

            Ffisher_distribution = compute_distribution(Ffisher, 1);


            timer4.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            GenerateNormalRV RVgen = new GenerateNormalRV();


            Tstudent = new List<double>();

            for (int i = 0; i < numbersamples; i++)
            {
                (double X, double Y) = RVgen.getNewPair();


                Tstudent.Add(X / Math.Sqrt((Y * Y)));
            }


            Tstudent = Tstudent.Where(x => (x >= -50 && x <= 50)).ToList();


            Tstudent_distribution = compute_distribution(Tstudent, 1);

            timer5.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawHistogram(chisquared_distribution, r2, g, "Chi-squared");
            pictureBox1.Image = b;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawHistogram(cauchy_distribution, r3, g, "Cauchy");
            pictureBox1.Image = b;

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawHistogram(Ffisher_distribution, r4, g, "Fisher-Snedocor");
            pictureBox1.Image = b;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawHistogram(Tstudent_distribution, r5, g, "T-Student");
            pictureBox1.Image = b;
        }
    }
}