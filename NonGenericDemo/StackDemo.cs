using System;
using System.Collections;


namespace NonGenericDemo
{
    internal class StackDemo
    {
        public static void stackDemoExample()
        {
            Stack s= new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push('f');
            s.Push(true);

            foreach(var i in s)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" After pop operation"+s.Pop()); // true will be removed

            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
        }

    }
}
