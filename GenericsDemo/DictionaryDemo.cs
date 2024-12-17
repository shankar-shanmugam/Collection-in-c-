using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class DictionaryDemo
    {
        public static void DemoDictionary()
        {
            Dictionary<int,string> map= new Dictionary<int,string>();
            map.Add(1, "santhosh");
            map.Add(2, "ram");
          //  map.Add(false, "4"); error : cause it only accept int type as key

            foreach(var entry in map)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }


        }
    }
}
