using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericDemo
{
    internal class ArrayListDemo
    {
        public static void Demo()
        {
            // demo for arraylist
            ArrayList list= new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add('r');
            list.Add("hi");
            list.Add(true);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }



        }

    }
}
