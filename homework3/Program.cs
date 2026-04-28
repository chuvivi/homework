namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的字串：");
            string[] num = Console.ReadLine().Split(',');
            for (int i = num.Length -1; i >= 0; i-- )
            {
                Console.Write(num[i]);

                if (i > 0)
                {
                    Console.Write(",");
                }
            }

        }
    }
}