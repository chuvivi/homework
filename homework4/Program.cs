namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("結果如下：");

            for ( int i = num; i>=1; i--)
            {
                for(int j = 1; j <= num - i + 1; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
