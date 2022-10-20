using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class InfixConversions
    {
        public static void Solution(string input)
        {
            Stack<string> operandsPre = new Stack<string>();
            Stack<string> operandsPost = new Stack<string>();

            Stack<char> oper = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    oper.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    while (oper.Peek() != '(')
                    {
                        char op = oper.Pop();
                        string v2pre = operandsPre.Pop();
                        string v1pre = operandsPre.Pop();
                        string preString = op + v1pre + v2pre;
                        operandsPre.Push(preString);
                        string v2post = operandsPost.Pop();
                        string v1post = operandsPost.Pop();
                        string postString = v1pre + v2pre + op;
                        operandsPost.Push(postString);
                    }
                    oper.Pop();
                }

                else if (char.IsLetter(input[i]) || char.IsDigit(input[i]))
                {
                    operandsPre.Push("" + input[i]);
                    operandsPost.Push("" + input[i]);

                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*')
                {
                    while (oper.Count > 0 && input[i] != '(' && precedence(input[i]) >= precedence(oper.Peek()))
                    {
                        char op = oper.Pop();
                        string v2pre = operandsPre.Pop();
                        string v1pre = operandsPre.Pop();
                        string preString = op + v1pre + v2pre;
                        operandsPre.Push(preString);
                        string v2post = operandsPost.Pop();
                        string v1post = operandsPost.Pop();
                        string postString = v1pre + v2pre + op;
                        operandsPost.Push(postString);
                    }
                    oper.Push( input[i]);
                   
                }
            }

            while (oper.Count > 0)
            {
                char op = oper.Pop();
                string v2pre = operandsPre.Pop();
                string v1pre = operandsPre.Pop();
                string preString = op + v1pre + v2pre;
                operandsPre.Push(preString);
                string v2post = operandsPost.Pop();
                string v1post = operandsPost.Pop();
                string postString = v1pre + v2pre + op;
                operandsPost.Push(postString);
            }

            Console.WriteLine(operandsPre.Peek());
            Console.WriteLine(operandsPost.Peek());


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
