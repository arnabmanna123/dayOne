using System;
using System.Collections;
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


        static void TowerOfHonoi(int number, int t1Id, int t2Id, int t3Id)
        {
            if (number == 0)
            {
                return;
            }
            TowerOfHonoi(number - 1, t1Id, t3Id, t2Id); //will print the instructions to move n-1 disks that means 2 disks from t1 to t3 using t2 (if they follow the instruction )
            Console.WriteLine(number + " [" + t1Id + "->" + t2Id + " ]");
            TowerOfHonoi(number - 1, t3Id, t2Id, t1Id); //again placeing the disk from disk three to the disk 2
        }
        static void ZigZag(int number)
        {
            if (number == 0)
            {
                return;
            }
            Console.WriteLine("pre:" + number);
            ZigZag(number - 1);
            Console.WriteLine("in :" + number);
            ZigZag(number - 1);
            Console.WriteLine("Post :" + number);
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

        static int MaxNumberOfAnArray(List<int> input, int idx)
        {

            if (idx >= input.Count)
            {
                return input[idx - 1];
            }
            else
            {
                int a = MaxNumberOfAnArray(input, idx + 1);
                if (a < input[idx])
                {
                    return input[idx];
                }
                return a;

            }
        }

        static int FirstOccuerenceOfTheNumber(List<int> input, int number, int idx)
        {

            if (idx >= input.Count)
            {
                return -1;
            }

            int result = FirstOccuerenceOfTheNumber(input, number, idx + 1);
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


            int result = LastOccuerenceOfTheNumber(input, number, idx + 1);
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

        static int NumofOccurenceOfANumber(List<int> input, int number, int occurence, int idx)
        {
            if (idx >= input.Count)
            {
                return occurence;
            }

            if (input[idx] == number)
            {
                return NumofOccurenceOfANumber(input, number, occurence + 1, idx + 1);

            }
            else
            {
                return NumofOccurenceOfANumber(input, number, occurence, idx + 1);

            }

        }
        static int[] NumofOccurenceOfANumberArray(List<int> input, int number, int occurence, int idx)
        {
            if (idx >= input.Count)
            {
                return new int[occurence];
            }

            if (input[idx] == number)
            {
                var result = NumofOccurenceOfANumberArray(input, number, occurence + 1, idx + 1);
                result[occurence] = idx;
                return result;
            }
            else
            {
                var result1 = NumofOccurenceOfANumberArray(input, number, occurence, idx + 1);
                return result1;


            }

        }


        // bc = --,b-, -c, bc
        //abc= -,b-, --c, -bc , a--,ab-, a-c, abc
        static ArrayList SubsString(string input)
        {
            if (input.Length <= 0)
            {
                return new ArrayList() { "" };
            }

            else
            {
                char a = input.ToCharArray()[0]; //a
                string ros = input.Substring(1); // bc
                ArrayList arrayList = SubsString(ros);// --,b-, -c, bc

                var newlist = new ArrayList();
                foreach (var local in arrayList)
                {
                    newlist.Add("" + local.ToString());
                    newlist.Add(a + local.ToString());

                }
                return newlist;
            }



        }


        static ArrayList KeyPadCombination(List<string> input, string number)
        {
            if (number.Length == 0)
            {
                return new ArrayList() { "" };
            }
            else
            {
                int lastNumber = Convert.ToInt32(number.Substring(0, 1)); // storing the '5'
                var result = KeyPadCombination(input, number.Substring(1)); //6 words '73'


                var finalREsult = new ArrayList();

                for (int i = 0; i < input[lastNumber].Length; i++)
                {
                    char chCode = input[lastNumber].ToCharArray()[i];
                    for (int j = 0; j < result.Count; j++)
                    {
                        finalREsult.Add(chCode + result[j].ToString());
                    }
                }

                return finalREsult;
            }
        }



        static List<string> getStairPaths(int n)
        {
            if (n == 0)// when its not negetive
            {
                return new List<string>() { "" };
            }
            else if (n < 0)//when the value is negetive 
            {
                return new List<string>();
            }
            List<string> path1 = getStairPaths(n - 1);
            List<string> path2 = getStairPaths(n - 2);
            List<string> path3 = getStairPaths(n - 3);


            List<string> anewList = new List<string>();

            for (int i = 0; i < path1.Count; i++)
            {
                anewList.Add("1" + path1[i]);
            }

            for (int j = 0; j < path2.Count; j++)
            {
                anewList.Add("2" + path2[j]);

            }


            for (int k = 0; k < path3.Count; k++)
            {
                anewList.Add(3 + path3[k]);
            }

            return anewList;


        }

        static List<string> GetMazePath(int sr, int sc, int dr, int dc)
        {
            if (sc == dc && sr == dr)
            {
                return new List<string> { "" };
            }

            List<string> HPath = new List<string>();
            List<string> LPath = new List<string>();

            if (sr < dr)
            {
                HPath = GetMazePath(sr + 1, sc, dr, dc);
            }
            if (sc < dc)
            {
                LPath = GetMazePath(sr, sc + 1, dr, dc);
            }
            List<string> anewPath = new List<string>();

            for (int i = 0; i < HPath.Count; i++)
            {
                anewPath.Add("h" + HPath[i]);
            }

            for (int j = 0; j < LPath.Count; j++)
            {
                anewPath.Add("v" + LPath[j]);
            }

            return anewPath;
        }

        static List<string> GetMazePathWithJump(int sr, int sc, int dr, int dc)
        {
            if (sr == dr && sc == dc)
            {
                return new List<string> { "" };
            }
            List<string> result = new List<string>();
            //horizonatal moves
            for (int i = 1; i <= dc - sc; i++)
            {
                var Hpath = GetMazePathWithJump(sr, sc + i, dr, dc);//ek jump then two jump then three
                foreach (var jump in Hpath)
                {
                    result.Add("h" + i.ToString() + jump);
                }
            }

            //vartical moves
            for (int j = 1; j <= dr - sr; j++)
            {
                var vpath = GetMazePathWithJump(sr + j, sc, dr, dc);//ek jump then two jump then three
                foreach (var jump in vpath)
                {
                    result.Add("v" + j.ToString() + jump);
                }
            }

            //diagonal
            for (int k = 1; (k <= dr - sr && k <= dc - sc); k++)
            {
                var dpath = GetMazePathWithJump(sr + k, sc + k, dr, dc);//ek jump then two jump then three
                foreach (var jump in dpath)
                {
                    result.Add("d" + k.ToString() + jump);
                }
            }

            return result;
        }

        static void PrintSubsequence(string input, string result)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(result);
                return;
            }
            char ch = input.ToCharArray()[0];
            PrintSubsequence(input.Substring(1), result + ch);
            PrintSubsequence(input.Substring(1), result + "");



        }

        static void Permutations(string input, string result)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(result);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input.ToCharArray()[i];
                string left = input.Substring(0, i);
                string right = input.Substring(i + 1);

                Permutations(left + right, result + ch);
            }
        }


        static void PrintEncodings(string input, string output)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(output);
            }
            else if (input.Length == 1)
            {
                char ch = input.ToCharArray()[0];
                if (ch == '0')
                {
                    return;
                }
                else
                {
                    int chv = ch - '0';
                    char code = (char)('a' + chv - 1);
                    output = output + code;
                    Console.WriteLine(output);
                    return;
                }

            }
            else
            {
                char ch = input.ToCharArray()[0];
                string sub = input.Substring(1);
                if (ch == '0')
                {
                    return;
                }
                else
                {
                    int chv = ch - '0';//convert in int
                    char code = (char)('a' + chv - 1);//to convert to char
                    PrintEncodings(sub, output + code);
                }

                string chs = input.Substring(0, 2);
                string subs = input.Substring(2);
                int chInt = Convert.ToInt32(chs);
                if (chInt <= 26)
                {
                    char code = (char)('a' + chInt - 1);
                    PrintEncodings(subs, output + code);
                }
            }
        }

        static void FloodFill(int[][] maze, int row, int col, string psf, bool[][] visited)//visited to check theone path cant be use twice
        {
            if (row < 0 || col < 0 || row == maze.Length || col == maze[0].Length || maze[row][col] == 1 || visited[row][col]==true)// maze[row][col]==1 obstrcle, should be the end as the if the row or col is negetive which will throw exception
            {
                return;
            }
            if(row==maze.Length-1 && col == maze[0].Length)
            {
                Console.WriteLine(psf);
                return;
            }
            visited[row][col] = true;
            FloodFill(maze, row - 1, col, psf + "t", visited);
            FloodFill(maze, row, col-1, psf + "l", visited);
            FloodFill(maze, row + 1, col, psf + "d", visited);
            FloodFill(maze, row, col+1, psf + "r", visited);
            visited[row][col] = false; //if any path can use for another way for that reason
           
        }


        static void TargetSumSubsets(List<int> input , int idx  , string set , int sumOfSet, int target)
        {
            if (idx == input.Count)
            {
                if (sumOfSet == target)
                {
                    Console.WriteLine(set+".");
                }
                return;
            }
            TargetSumSubsets(input, idx + 1, set + input[idx].ToString() + " , ", sumOfSet + input[idx], target);
            TargetSumSubsets(input, idx + 1, set , sumOfSet , target);

        }

        //static void PrintNQueen(int[][] chess, string printSoFar , int row)// imcomplete
        //{
        //    if()
        //    for(int col=0; col<chess.Length; col++)
        //    {
        //        chess[row][col] = 1;
        //        PrintNQueen(chess, printSoFar + row.ToString() + "-" + col.ToString() + ",", row+1);
        //        chess[row][col] = 0;//its important to remove them too
        //    }
        //}

        static void KnightsTour(int[][] chess, int r, int c, int move)
        {
            if (r < 0 || c < 0 || r >= chess.Length || c >= chess[0].Length || chess[r][c]!=0)
            {
                return;
            }
            else if (chess[r][c] == chess.Length)
            {
                chess[r][c] = move;
                Console.WriteLine("");
                chess[r][c] = 0;
                return;
            }

            chess[r][c] = move;
            KnightsTour(chess, r - 2, c + 1, move + 1);
            KnightsTour(chess, r  -2, c - 1, move + 1);
            KnightsTour(chess, r -1, c - 2, move + 1);
            KnightsTour(chess, r + 1, c - 2, move + 1);
            KnightsTour(chess, r + 2, c + 1, move + 1);
            KnightsTour(chess, r + 2, c - 1, move + 1);
            KnightsTour(chess, r +1, c +2, move + 1);
            KnightsTour(chess, r -1, c + 2, move + 1);
            chess[r][c] = 0;
        }
        static void Main(string[] args)
        {
            TargetSumSubsets(new List<int> { 10, 20, 30, 40, 50 }, 0, "", 0, 60);
            //PrintEncodings("12103", "");
            //Permutations("abcd","");
            //Permutations("abc", "");
            //var mazePath = GetMazePathWithJump(1, 1, 3, 3);
            //var result =getStairPaths(4);
            //var result = KeyPadCombination(new List<string> { "?!", "abc","def","ghi","jkl","mnop","qrst","uv","wxyz",",;"}, "573");
            //var result = SubsString("a");
            //var result = NumofOccurenceOfANumberArray(new List<int> { 12, 43, 33, 13, 23, 43, 43 }, 43, 0, 0);
            //Console.WriteLine(NumofOccurenceOfANumber(new List<int> { 12, 43, 33, 13,23,43 ,43}, 43, 0,0));
            //Console.WriteLine(LastOccuerenceOfTheNumber(new List<int> { 12, 43, 33, 13, 43 }, 43, 0));


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
