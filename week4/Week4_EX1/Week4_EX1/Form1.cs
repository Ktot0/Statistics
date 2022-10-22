using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace Week4_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> units = new List<int>();
            List<double> freq = new List<double>();
            Random random = new Random();
            for(int i = 0; i < 101; i++)
            {
                units.Add(random.Next(0, 2));
            }



            int succ = 0;
            int total = 1;
            for(int i = 0; i < 101; i++)
            {
                if (units[i] == 0)
                {
                    succ++;
                }        
                double res = (double)succ / total;
                freq.Add(res);
                total++;

            }

            var series1 = new LiveCharts.Wpf.LineSeries()
            {
                Title = "Relative Frequency",
                Values = new LiveCharts.ChartValues<double>(freq),
            };

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(series1);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> units = new List<int>();
            List<int> absolute = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 101; i++)
            {
                units.Add(random.Next(0, 2));
            }



            int succ = 0;
            for (int i = 0; i < 101; i++)
            {
                if (units[i] == 1)
                {
                    succ++;
                }

                absolute.Add(succ);
            }

            var series1 = new LiveCharts.Wpf.LineSeries()
            {
                Title = "Absolute Frequency",
                Values = new LiveCharts.ChartValues<int>(absolute),
            };

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(series1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> units = new List<int>();
            List<double> freq = new List<double>();
            Random random = new Random();
            for (int i = 0; i < 101; i++)
            {
                units.Add(random.Next(0, 2));
            }



            int succ = 0;
            int total = 1;
            for (int i = 0; i < 101; i++)
            {
                if (units[i] == 0)
                {
                    succ++;
                }
                double res = (double)succ / Math.Sqrt(total);
                freq.Add(res);
                total++;

            }

            var series1 = new LiveCharts.Wpf.LineSeries()
            {
                Title = "Normalized Frequency",
                Values = new LiveCharts.ChartValues<double>(freq),
            };

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(series1);
        }
    }
}
