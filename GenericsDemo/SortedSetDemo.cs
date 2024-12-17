using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class SortedSetDemo
    {
        public static void DemoSortedSet()
        {

            SortedSet<double> s= new SortedSet<double>();
            
            s.Add(2.3);
            s.Add(4.6);
            s.Add(1.1);

            foreach(double d in s)
            {
                Console.WriteLine(d);
            }

        }

    }
}
