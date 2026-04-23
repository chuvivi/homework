namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串整數，並用逗號分隔：");
            string input = Console.ReadLine();
            string[] num = input.Split(',');

            // 建立一個放奇數的整數陣列
            // 長度先開成 parts.Length，確保一定放得下
            int[] oddNumbers = new int[num.Length];
            // 建立一個放偶數的整數陣列
            int[] evenNumbers = new int[num.Length];

            // 記錄目前放了幾個奇數
            int oddCount = 0;
            // 記錄目前放了幾個偶數
            int evenCount = 0;

            // foreach 會把 parts 裡面的每一個字串，一個一個拿出來處理
            foreach (string part in num)
            {
                // 把字串轉成整數
                // 例如 "8" 變成 8
                int number = int.Parse(part);

                // 判斷是不是偶數
                // 如果 num 除以 2 的餘數是 0，就代表它是偶數
                if (number % 2 == 0)
                {
                    // 把偶數放進 evenNumbers 陣列裡
                    evenNumbers[evenCount] = number;

                    // 放完之後，偶數數量加 1
                    evenCount++;
                }
                else
                {
                    // 如果不是偶數，那就是奇數
                    // 把奇數放進 oddNumbers 陣列裡
                    oddNumbers[oddCount] = number;

                    // 放完之後，奇數數量加 1
                    oddCount++;
                }
            }

            // 將奇數陣列中「真正有放資料的部分」做排序
            // 從索引 0 開始，排 oddCount 個
            Array.Sort(oddNumbers, 0, oddCount);

            // 將偶數陣列中「真正有放資料的部分」做排序
            // 從索引 0 開始，排 evenCount 個
            Array.Sort(evenNumbers, 0, evenCount);

            // 先印出「奇數 : 」
            Console.Write("奇數 : ");

            // 用 for 迴圈把奇數一個一個印出來
            for (int i = 0; i < oddCount; i++)
            {
                // 印出目前這一個奇數
                Console.Write(oddNumbers[i]);

                // 如果這不是最後一個，就再印一個逗號
                if (i < oddCount - 1)
                {
                    Console.Write(",");
                }
            }

            // 換行
            Console.WriteLine();

            // 先印出「偶數 : 」
            Console.Write("偶數 : ");

            // 用 for 迴圈把偶數一個一個印出來
            for (int i = 0; i < evenCount; i++)
            {
                // 印出目前這一個偶數
                Console.Write(evenNumbers[i]);

                // 如果這不是最後一個，就再印一個逗號
                if (i < evenCount - 1)
                {
                    Console.Write(",");
                }
            }

            // 最後換行
            Console.WriteLine();
        }
    }
}
