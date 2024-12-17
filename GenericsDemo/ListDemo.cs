using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    internal class ListDemo
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            // using add method
            list.Add('c');
            list.Add('a');
            list.Add('d');
            list.Add('h');

            foreach (char c in list)
            {
                Console.WriteLine(c);
            }

            // using collection initializer in List

            List<string> list2 = new List<string>() { "hi", "hello", "good", "Morning" };
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            // custom object adding into list

            List<Student> list3 = new List<Student>();
            list3.Add(new Student() { Id=1,Name="shankar",Dob=DateTime.Parse("03-09-2002")});
            list3.Add(new Student() { Id=2,Name="Ramkumar",Dob=DateTime.Parse("11-04-2001")});
            list3.Add(new Student() { Id=3,Name="Yogesh",Dob=DateTime.Parse("03-11-2004")});

            foreach (Student s in list3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" using AddRange() ");

            // using AddRange() method to add another list into this
            List<Student> studentList = new List<Student>() { new Student() { Id = 45, Name = "muthun" } };
            studentList.AddRange(list3);

            foreach (Student s in studentList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After using remove() to remove all elements form the collection");

            // remove() to remove all elements
            studentList.Clear();

            foreach (Student s in studentList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("capacity method in arrayList");

            list3.Capacity = 10;
            list3.Add(new Student());

            foreach (Student s in list3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("----------------Reverse method to reverse list-------------------");

            list.Reverse();
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }


        }
    }
}
