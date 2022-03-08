using System;
using System.Threading;

namespace _NumRun_with_no_func
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            const string LINE = "----------------------------------";

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(1000); // 딜레이 (1000 = 1초)
                Console.Clear(); // 화면 지우기

                ++runA;
                ++runB;
                ++runC;
                ++runD;

                Console.WriteLine(LINE);

                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("1");

                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("2");

                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("3");

                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("4");

                Console.WriteLine(LINE);
            }
        }
    }
}
