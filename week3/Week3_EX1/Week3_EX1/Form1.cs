using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using System.Diagnostics;

namespace Week3_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Files|*.csv";
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }

        public List<Student> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(",")
                        select new Student
                        {
                            Number = int.Parse(data[0]).ToString(),
                            Length = int.Parse(data[1])
                        };
            return query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadCSV(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Check 1");
            string rows = dataGridView1.Rows.Count.ToString();
            Dictionary<string, int> map = new Dictionary<string, int>();
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

            BindingSource _bindingSource = new BindingSource();
            dataGridView2.DataSource = _bindingSource;
            _bindingSource.DataSource = map;



        }
    }

    public class Student
    {
        public string Number { get; set; }
        public int Length { get; set; }

    }
}