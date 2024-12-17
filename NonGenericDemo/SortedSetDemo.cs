using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericDemo
{
    internal class SortedSetDemo
    {
        public static void Example()
        {

            SortedList list = new SortedList();
            list.Add(100, 4);
            list.Add(4,'r');
            list.Add(2, 6);

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

        }

    }
}
