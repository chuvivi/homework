namespace homework8周六與周日_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 先讀取使用者輸入的民國年
            int rocYear = int.Parse(textBox1.Text);

            // 將民國年轉成西元年
            int year = rocYear + 1911;

            // 記錄星期六和星期日的天數
            int saturdayCount = 0;
            int sundayCount = 0;

            // 建立這個西元年的 1 月 1 日
            DateTime start = new DateTime(year, 1, 1);

            // 建立下一年的 1 月 1 日
            DateTime end = new DateTime(year + 1, 1, 1);

            // 從 1 月 1 日開始，一天一天檢查到年底
            for (DateTime day = start; day < end; day = day.AddDays(1))
            {
                // 如果這一天是星期六
                if (day.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                // 如果這一天是星期日
                else if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            // 顯示結果
            label1.Text = $"星期六 {saturdayCount} 天，星期日 {sundayCount} 天";
        }
    }
}
