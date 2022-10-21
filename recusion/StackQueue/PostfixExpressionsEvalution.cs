using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class PostfixExpressionsEvalution
    {
        public static void Solution(string input)
        {
            Stack<char> opr = new Stack<char>();
            Stack<int> oparend = new Stack<int>();
            Stack<string> postFix = new Stack<string>();
            Stack<string> infix = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
           
                 if (char.IsDigit(input[i]))
                {
                    oparend.Push(input[i] - '0');
                    postFix.Push("" + input[i]);
                    infix.Push("" + input[i]);


                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    //while (opr.Count > 0 && opr.Peek() != '(' && precedence(input[i]) <= precedence(opr.Peek()))
                    //{
                    opr.Push(input[i]);
                    var oprator = opr.Peek();
                    var v2 = oparend.Pop();//
                    var v1 = oparend.Pop();
                    int res = operation(oprator, v1, v2);
                    oparend.Push(res);

                    string v2In = infix.Pop();
                    string v1In = infix.Pop();
                    string InString = "(" + v1In + oprator + v2In + ")";
                    infix.Push(InString);
                    string v2Post = postFix.Pop();
                    string v1Post = postFix.Pop();
                    string PostString =   v1Post + v2Post+input[i];
                    postFix.Push(PostString);

                    //}


                }
            }
      

            Console.WriteLine(oparend.Peek());
            Console.WriteLine(infix.Peek());
            Console.WriteLine(postFix.Peek());
        }
        public static int operation(char oparator, int v1, int v2)
        {
            if (oparator == '+')
            {
                return v1 + v2;
            }
            else if (oparator == '-')
            {
                return v1 - v2;
            }
            else if (oparator == '*')
            {
                return v1 * v2;
            }
            else
            {
                return v1 / v2;
            }
        }
        public static int precedence(char optor)
        {
            if (optor == '+')
            {
                return 1;
            }
            else if (optor == '-')
            {
                return 1;
            }
            else if (optor == '*')
            {
                return 2;
            }
            else
            {
                return 2;
            }
        }
    }
}
