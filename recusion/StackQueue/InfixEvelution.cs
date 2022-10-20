using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class InfixEvelution
    {
        public static int Solution(string input)
        {
            Stack<char> opr = new Stack<char>();
            Stack<int> oparend = new Stack<int>();

            for(int i=0; i<input.Length; i++)
            {
                if (input[i] == '(')
                {
                    opr.Push(input[i]);
                }
                else if(input[i] == ')'){
                    while (opr.Peek() != '(')
                    {
                        char oper = opr.Pop();
                        int v2 = oparend.Pop();
                        int v1 = oparend.Pop();
                        var value = operation(oper, v1, v2);
                        oparend.Push(value);
                    }
                    opr.Pop();//pop the '('
                }
                else if(char.IsDigit( input[i]))
                {
                    oparend.Push(input[i]-'0');
                }
                else if(input[i]=='+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    while(opr.Count>0 && opr.Peek()!='(' && precedence(input[i]) <= precedence(opr.Peek()))
                    {
                        var oprator = opr.Pop();
                        var v2 = oparend.Pop();
                        var v1 = oparend.Pop();
                        int res = operation(oprator, v1, v2);
                        oparend.Push(res);
                    }

                    opr.Push(input[i]);
                }
            }
            //for extra all elements
            while (opr.Count>0)
            {
                char oper = opr.Pop();
                int v2 = oparend.Pop();
                int v1 = oparend.Pop();
                int value = operation(oper, v1, v2);
                oparend.Push(value);
            }


            return oparend.Peek();
        }


        public static int operation(char oparator , int v1 , int v2)
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

        public static int  precedence(char optor)
        {
            if (optor == '+')
            {
                return 1;
            }
            else if(optor=='-')
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
