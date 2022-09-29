using System;

namespace recusion
{
    class Program
    {
        static int AddNNumbers(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n + AddNNumbers(n - 1);
            }
        }


        static double PowerOfN(int b,int n)
        {
            if (n ==0)
            {
                return 1;
            }
            else
            {
                var value =b* PowerOfN(b, n - 1);
                return value;
            }
        }

        static void PrintCountingTail(int number)
        {
            if (number == 0)
            {
                
            }
            else
            {
                PrintCountingTail(number  - 1);
                Console.WriteLine(number);
                
            }
        }
        static int PrintCountingHead(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(number);
                return PrintCountingHead(number - 1);
             
                
            }
        }

        static int Factorial(int number)
        {
            if (number <=1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }


        static int FibonaccciSeries(int num)
        {
            if(num==0)
            {
                return num;
            }
           else if (num == 1)
            {
                return num;
            }
            else
            {
                return FibonaccciSeries(num - 1) + FibonaccciSeries(num - 2);
            }
        }


        static void Main(string[] args)
        {
            int a = AddNNumbers(5);
            var power = PowerOfN(2,3);
            PrintCountingTail(5);
            PrintCountingHead(5);
            Console.WriteLine(Factorial(3));

            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine(FibonaccciSeries(i));
            }
            Console.ReadLine();
        }
    }
}
