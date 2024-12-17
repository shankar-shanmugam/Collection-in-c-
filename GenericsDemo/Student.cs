using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class Student
    {
        int id;
        public int Id { set { id = value; } get { return id; } }

        string name;
        public string Name { set { name = value; } get { return name; } }

        DateTime dob;
        public DateTime Dob { set { dob = value; } get {return dob; } }


        public override string ToString()
        {
            return $"student id is {this.id} and student name is {name} and student dob is {dob}";
        }

    }
}
