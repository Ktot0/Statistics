using System.Collections.Generic;

namespace Week6_EX1
{
    public partial class Form1 : Form
    {
        private List<sample> list_totale = new List<sample>();
        public int totalRow = 0;
        public List<double> list = new List<double>();
        public Form1()
        {
            InitializeComponent();
            var parsedData = new List<string[]>();
            using (var sr = new StreamReader("trees.csv"))
            {
                string line;
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null && totalRow < 262)
                {
                    string[] row = line.Split(',');
                    parsedData.Add(row);
                    totalRow++;
                }

            }

            foreach (string[] row in parsedData)
            {
                dataGridView1.Rows.Add(row);
            }
            trackBar1.Maximum = totalRow;
        }

        double calc_mean_pop(List<double> list)
        {
            double mean;
            double temp_sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                temp_sum = temp_sum + (double)list[i];
            }
            mean = temp_sum / (double)list.Count;
            return mean;
        }

        double calc_variance_pop(List<double> list, double mean)
        {
            double variance;
            double temp_sum = 0;


            for (int i = 0; i < list.Count; i++)
            {
                temp_sum = temp_sum + (Math.Pow((list[i] - mean), 2));
            }
            variance = temp_sum / list.Count;
            return variance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mean;
            double variance;
            int number_of_sample = Convert.ToInt32(this.trackBar1.Value);
            int set_of_sample = Convert.ToInt32(this.trackBar2.Value);

            string column = this.textBox1.Text;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Name == column)
                {
                    for (int j = 0; j < totalRow; j++)
                    {
                        list.Add(Convert.ToDouble((string)dataGridView1[i, j].Value));
                    }
                }

            }
            mean = calc_mean_pop(list);
            variance = calc_variance_pop(list, mean);
            textBox4.Text = mean.ToString("0.###");
            textBox5.Text = variance.ToString("0.###");

            double mt;
            double mean_mt;
            double mvt;
            double variance_mt;
            double vvt;
            Random rnd = new Random();
            List<double> mean_of_mean = new List<double>();
            List<double> mean_of_variance = new List<double>();

            for (int i = 0; i < set_of_sample; i++)
            {
                List<double> list_temp = new List<double>();
                for (int j = 0; j < number_of_sample; j++)
                {
                    int num = rnd.Next(0, list.Count);
                    list_temp.Add(list[num]);
                }
                mt = calc_mean_pop(list_temp);
                mean_of_mean.Add(mt);
                mean_of_variance.Add(calc_variance_pop(list_temp, mt));

            }

            mean_mt = calc_mean_pop(mean_of_mean);
            mvt = calc_mean_pop(mean_of_variance);
            variance_mt = calc_variance_pop(mean_of_mean, mean_mt);
            vvt = calc_variance_pop(mean_of_variance, calc_mean_pop(mean_of_variance));

            textBox6.Text = mean_mt.ToString("0.###");
            textBox8.Text = mvt.ToString("0.###");
            textBox7.Text = variance_mt.ToString("0.###");
            textBox9.Text = vvt.ToString("0.###");
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Columns[e.ColumnIndex].Name;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar2.Value.ToString();
        }
    }
}