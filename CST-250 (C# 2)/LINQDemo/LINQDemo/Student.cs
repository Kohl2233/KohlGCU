using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Student : IComparable<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public int CompareTo(Student other)
        {
            // return 0: if current instance is equal to other objects property
            // return 1: if current instance is greater than other objects property
            // retunr -1: if current instance is less than otehr objects property

            if (this.grade == other.grade)
            {
                return 0;
            } else if (this.grade > other.grade)
            {
                return 1;
            } else
            {
                return -1;
            }
        }
    }
}
