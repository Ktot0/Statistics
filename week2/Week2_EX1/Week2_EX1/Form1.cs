namespace Week2_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            for (int i = 0; i < 20; i++)
            {
                number = random1.NextDouble();
                richTextBox1.AppendText(number.ToString()+"\n");
            }
        }
        Random random1 = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double number;
            for (int i = 0; i < 20; i++)
            {
                number = random1.NextDouble();
                richTextBox1.AppendText(number.ToString() + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }
    }
}