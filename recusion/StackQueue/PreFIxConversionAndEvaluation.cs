using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class PreFIxConversionAndEvaluation
    {
        public static void Solution(string input)
        {
            Stack<string> postFix = new Stack<string>();
            Stack<string> infix = new Stack<string>();
            Stack<int> operend = new Stack<int>();

            for(int i=input.Length-1; i>=0;i--)
            {
                if(input[i]=='+' || input[i]=='-' || input[i]=='/' || input[i] == '*')
                {
                    int v1 = operend.Pop(); // the difference is here
                    int v2= operend.Pop();
                    int res = operation(input[i], v1, v2);
                    operend.Push(res);

                    string postV1 = postFix.Pop();
                    string postV2 = postFix.Pop();
                    string postRes = postV1 + postV2 + input[i];
                    postFix.Push(postRes);

                    string inV1= infix.Pop();
                    string inV2 = infix.Pop();
                    string inString = "(" + inV1 + input[i] + inV2 + ")";
                    infix.Push(inString);
                }
                else
                {
                    operend.Push(input[i] - '0');
                    infix.Push(input[i] + "");
                    postFix.Push(input[i] + "");
                }
            }
 
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
    }
}
