using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class StackDemo
    {
        public static void stackDemoExample()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push('f'); // internally it will store as int only ,so value print as 102
           // s.Push(true); error

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

        }
    }
}