using System;
using System.Collections.Generic;

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


        static double PowerOfN(int b, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                var value = b * PowerOfN(b, n - 1);
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
                PrintCountingTail(number - 1);
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
            if (number <= 1)
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
            if (num == 0)
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


        static void PrintNumberToWords(int num)
        {
            var words = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            if (num <= 0)
            {

            }
            else
            {
                //Console.WriteLine(num % 10);

                PrintNumberToWords(num / 10);
                Console.WriteLine(words[num % 10]);
            }
        }

        static int powerValueResturn(int b, int power)
        {
            if (power <= 0)
            {
                return 1;
            }
            else
            {
                int exp = powerValueResturn(b, power / 2);
                if (power % 2 != 0)
                {
                    return 2 * exp * exp;
                }
                else
                {
                    return exp * exp;
                }
            }
        }

        static bool sortedOrUnsorted(List<int> a, int index)
        {
            if (index > a.Count)
            {
                return true;
            }
            else if (a[index] - a[index - 1] > 0)
            {
                return false;
            }
            else
            {
                return sortedOrUnsorted(a, index + 1);

            }
        }

        static int powerOfN(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * powerOfN(x, n - 1);
            }
        }

        static int powerOfNAnother(int x, int n)
        {

            if (n <= 0)
            {
                return 1;
            }
            int value = powerOfNAnother(x, n / 2);

             int final = value * value;
            if (n % 2 != 0)
            {
                final = final * x;
            }
            return final;
         }


        static void TowerOfHonoi(int number , int t1Id , int t2Id , int t3Id)
        {
            if (number == 0)
            {
                return;
            }
            TowerOfHonoi(number - 1, t1Id, t3Id, t2Id); //will print the instructions to move n-1 disks that means 2 disks from t1 to t3 using t2 (if they follow the instruction )
            Console.WriteLine(number + " ["+ t1Id +"->"+ t2Id +" ]");
            TowerOfHonoi(number - 1, t3Id, t2Id, t1Id); //again placeing the disk from disk three to the disk 2
        }
        static void ZigZag(int number)
        {
            if (number == 0)
            {
                return;
            }
            Console.WriteLine("pre:"+ number);
            ZigZag(number - 1);
            Console.WriteLine("in :"+ number);
            ZigZag(number - 1);
            Console.WriteLine("Post :"+number);
        }
        static void dispalyArr(List<int> arr, int ixd)
        {
            if (ixd >= arr.Count)
            {
                return;
            }
            else
            {
                Console.WriteLine(arr[ixd]);
                dispalyArr(arr, ixd + 1);
            }
        }

        static void dispalyArrReverse(List<int> arr, int ixd)
        {
            if (ixd >= arr.Count)
            {
                return;
            }
            else
            {

                dispalyArrReverse(arr, ixd + 1);
                Console.WriteLine(arr[ixd]);
            }
        }

        static int MaxNumberOfAnArray(List<int> input,int idx) 
        {
            
            if (idx >= input.Count)
            {
                return input[idx-1];
            }
            else
            {
                int a = MaxNumberOfAnArray(input, idx + 1);
                if (a < input[idx])
                {
                    return  input[idx];
                }
                return a;

            }
        }

        static int FirstOccuerenceOfTheNumber(List<int> input,int number, int idx)
        {

            if (idx >= input.Count)
            {
                return -1;
            }

           int result= FirstOccuerenceOfTheNumber(input,number, idx + 1);
            if (input[idx] == number)
            {
                return idx;
            }
            else
            {
                return result;
            }
        }

        static int LastOccuerenceOfTheNumber(List<int> input, int number, int idx)
        {

            if (idx >= input.Count)
            {
                return -1;
            }
          

            int result= LastOccuerenceOfTheNumber(input, number, idx + 1);
            if (result == -1)
            {
                if (input[idx] == number)
                {
                    return idx;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return result;
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LastOccuerenceOfTheNumber(new List<int> { 12, 43, 33, 13 ,43}, 43, 0));

            //int a =MaxNumberOfAnArray(new List<int> { 12, 43, 33,13 },0);
            //dispalyArrReverse(new List<int> { 1, 2, 3, 4, 56, 6 }, 0);
            //dispalyArr(new List<int> { 1, 2, 3, 4, 56, 6 }, 0);

            //TowerOfHonoi(3, 10, 11, 12);
            //ZigZag(3);
            //Console.WriteLine(powerOfNAnother(3, 9));
            //int a = AddNNumbers(5);
            //var power = PowerOfN(2,3);
            //PrintCountingTail(5);
            //PrintCountingHead(5);
            //Console.WriteLine(Factorial(3));

            //for(int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(FibonaccciSeries(i));
            //}
            //PrintNumberToWords(123);
            //int val =powerValueResturn(2, 3);
            //sortedOrUnsorted(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },1);
            Console.ReadLine();
        }
    }
}
