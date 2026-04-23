namespace homework6周六與周日_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);

            int saturdayCount = 0;
            int sundayCount = 0;

            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year + 1, 1, 1);

            for (DateTime day = start; day < end; day = day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            label1.Text = $"星期六 {saturdayCount} 天，星期日 {sundayCount} 天";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}