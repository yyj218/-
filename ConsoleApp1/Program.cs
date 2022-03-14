using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            Console.WriteLine("請輸入");
            int inputint = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i< inputint; i++)
            {
                for(int j=0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("2.");
            Console.WriteLine("請輸入數值");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < input; i++)
            {
                Console.WriteLine(input + "*" + i + "=" + i * input);
            }
            Console.WriteLine("3.");
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.Write(i + "*" + j+"=" + i * j); 
                }
                Console.WriteLine();
            }
            int[] s = { 1, 2, 3, 4, 5 };
            string[] sn = { "jack", "mary", "tom", "grace", "alice" };
            int[] computerscore = { 80, 65, 100, 98, 83 };
            int[] progarmscore = { 75, 67, 93, 25, 82 };
            int[] animationscore = { 60, 62, 91, 50, 87 };
            while (true)
            {
                Console.WriteLine("請輸入座號");
                var input2 = Console.ReadLine();
                int inputstudentno = int.Parse(input2);
                int arrayindex = Array.IndexOf(sn, inputstudentno);
               if(inputstudentno<6)
                {
                    Console.WriteLine("姓名" + sn[arrayindex]);
                    Console.WriteLine("電腦計概" + computerscore[arrayindex]);
                    Console.WriteLine("程式設計" + progarmscore[arrayindex]);
                    Console.WriteLine("動畫設計" + animationscore[arrayindex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
            }
        }
    }
}
