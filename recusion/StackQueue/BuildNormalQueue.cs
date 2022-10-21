using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class BuildNormalQueue
    {
        static int[] queue = new int[10];
        static int front = -1;
        static int rare = -1;


        public static void Push(int item)
        {
            if (front == queue.Length - 1)
            {
                Console.WriteLine("stack overloaded");
            }
            else
            {
                rare++;
                queue[rare] = item;
                

            }
        }

        public static void Display()
        {
            if (front == rare)
            {
                Console.WriteLine("The queue is empty");
            }
            for (int i=front+1 ; i<=rare; i++ )
            {
                Console.WriteLine(queue[i]);
            }
        }

        public static void Pop()
        {
            if (front >= rare)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                front++;
            }
        }

        public static int Count()
        {
            return rare - front;
        }

        public static int Peek()
        {
            if (front == rare)
            {
                throw new NullReferenceException("empty");
            }
            else
            {
                return queue[front];
            }
        }
    }
}
