using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericDemo
{
    internal class HashTableDemo
    {
        public static void HashTableExample()
        {
          Hashtable ht = new Hashtable();
            ht.Add(1, "shankar");
            ht.Add('r', 5);
            ht.Add(false, 65.6);

            foreach(DictionaryEntry v in ht)
            {
                Console.WriteLine(v.Key+" "+v.Value);
            }
        }


    }
}
