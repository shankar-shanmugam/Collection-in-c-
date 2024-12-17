using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericDemo
{
    internal class QueueDemo
    {
        public static void Example()
        {
            Queue list = new Queue();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue('f');
            list.Enqueue("fhuygf");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After dequeue" + list.Dequeue());// remove 1

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }
    }
}
