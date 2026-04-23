namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個中華民國年份");
            int ROCyear = int.Parse(Console.ReadLine());
            int ADyear = ROCyear + 1911;

            if (DateTime.IsLeapYear(ADyear))
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }
        }
    }
}
