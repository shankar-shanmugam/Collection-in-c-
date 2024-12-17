using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class QueueDemo
    {
        public static void Example()
        {
            Queue<char> list = new Queue<char>();
          //  list.Enqueue(1); error
            list.Enqueue('f');
            //   list.Enqueue("fhuygf"); error
            list.Enqueue('a');

            list.Enqueue('Z');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After dequeue" );
            list.Dequeue();

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }

    }
}
