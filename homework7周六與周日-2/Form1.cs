namespace homework7周六與周日_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);

            int saturdayCount = 52;
            int sundayCount = 52;

            DateTime firstDay = new DateTime(year, 1, 1);
            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                    sundayCount++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Friday)
                {
                    saturdayCount++;
                }
            }
            else
            {
                if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            label1.Text = $"星期六 {saturdayCount} 天，星期日 {sundayCount} 天";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
