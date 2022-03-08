using System;
using System.Threading;

namespace _NumRun_with_no_func
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            const string LINE = "------------------------------------------";
            const int END_LINE = 42;
            const int DELAY_TIME = 200;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(DELAY_TIME); // 딜레이 (1000 = 1초)
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

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int runNum = 0;
                    string strResult = "결과 : !!{0}번 선수 우승!!";

                    if (runA >= END_LINE)
                    {
                        runNum = 1;
                    }
                    else if (runB >= END_LINE)
                    {
                        runNum = 2;
                    }
                    else if (runC >= END_LINE)
                    {
                        runNum = 3;
                    }
                    else
                    {
                        runNum = 4;
                    }

                    Console.WriteLine(strResult, runNum);

                    Console.Write("다시하려면 0번 입력 :");
                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
