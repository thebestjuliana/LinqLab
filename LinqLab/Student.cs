using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CanDrive => Age >= 16;
        public bool CanDrink => Age >= 21;
        public bool Teenager => Age >= 13 && Age <= 19;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            
        }

        internal int IndexOfAny(char[] vowel)
        {
            throw new NotImplementedException();
        }
    }
}
