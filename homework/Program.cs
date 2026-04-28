namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字");
            int input = int.Parse(Console.ReadLine());
            if ( input % 2 == 0)
            {
                Console.WriteLine("數字為偶數");
            }
            else
            {
                Console.WriteLine("數字為奇數");
            }
        }
    }
}
