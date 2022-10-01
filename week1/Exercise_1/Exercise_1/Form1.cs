using System.DirectoryServices.ActiveDirectory;

namespace Exercise_1
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
                            Name = data[0],
                            Grade = int.Parse(data[1])
                        };
            return query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadCSV(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string lowest = (from DataGridViewRow row in dataGridView1.Rows
                            where row.Cells[1].FormattedValue.ToString() != String.Empty
                            select Convert.ToInt32(row.Cells[1].FormattedValue)).Min().ToString();

            richTextBox1.Text = "Lowest grade in the class\nGrade: " + lowest;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string highest = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[1].FormattedValue.ToString() != String.Empty
                              select Convert.ToInt32(row.Cells[1].FormattedValue)).Max().ToString();
            richTextBox1.Text = "Highest grade in the class\nGrade: " + highest;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a_mean = (from DataGridViewRow row in dataGridView1.Rows
                      where row.Cells[1].FormattedValue.ToString() != String.Empty
                      select Convert.ToInt32(row.Cells[1].FormattedValue)).Average().ToString("00.00");
            richTextBox1.Text = "Arithmetic mean of the class\nAverage: " + a_mean;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

    }
}