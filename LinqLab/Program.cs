using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            //For nums: 
            //1) Find the Minimum value
            Console.WriteLine($"Minimum number: {nums.Min()}");
            //2) Find the Maximum value 
            Console.WriteLine($"Maximum Number: {nums.Max()}");
            //3) Find the Maximum value less than 10000 
            Console.WriteLine($"Max Number, less than 1000: {nums.Where(x => x < 1000).Max()}");
            //4) Find all the values between 10 and 100 
            List<int> tenToOneHundred = nums.Where(x => x >= 10 && x <= 100).ToList();
            Console.Write($"Numbers between 10 and 100 (inclusive): ");
            foreach (int num in tenToOneHundred)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
            //5) Find all the Values between 100000 and 999999 inclusive 
            List<int> reallyBig = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.Write($"Numbers between 100000 and 999999 (inclusive): ");
            foreach (int num in reallyBig)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
            //6) Count all the even numbers
            var even = from num in nums
                       where num % 2 == 0
                       select num;

            Console.WriteLine($"Number of Even Numbers: {even.Count()}");

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13)); students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30)); students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15)); students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63)); students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));
            //For students:
            //1) Find all students age of 21 and over(aka US drinking age) 
            Console.Write($"Students who can drink: ");
            List<Student> drinkers = students.Where(x => x.CanDrink == true).ToList();
            foreach (Student student in drinkers)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine();
            //2) Find the oldest student 
            List<Student> oldStudent = students.Where(x => x.Age == students.Max(y => y.Age)).ToList();
            Console.Write($"Oldest Student:");
            foreach (Student student1 in oldStudent)
            {
                Console.Write($"{student1.Name}, ");
            }
            Console.WriteLine();
            //3) Find the youngest student 
            List<Student> youngStudent = students.Where(x => x.Age == students.Min(y => y.Age)).ToList();
            Console.Write($"Youngest Student:");
            foreach (Student student1 in youngStudent)
            {
                Console.Write($"{student1.Name}, ");
            }
            Console.WriteLine();
            //4) Find the oldest student under the age of 25 
            List<Student> under25 = students.Where(x => x.Age < 25).ToList();
            List<Student> oldStudentUnder25 = under25.Where(x => x.Age == under25.Max(y => y.Age)).ToList();
            Console.Write("Oldest Student under 25:");
            foreach (Student student1 in oldStudentUnder25)
            {
                Console.Write($"{student1.Name}, ");
            }
            Console.WriteLine();
            //5) Find all students over 21 and with even ages 
            Console.WriteLine($"Students over 21 and with an even age:");
            foreach (Student student in students.Where(x => x.CanDrink && x.Age % 2 == 0).ToList())
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
            //6) Find all teenage students(13 to 19 inclusive) 
            Console.WriteLine("Teenagers: ");
            List<Student> teenagers = students.Where(x => x.Teenager == true).ToList();
            foreach (Student teen in teenagers)
            {
                Console.WriteLine(teen.Name);
            }
            Console.WriteLine();
            //7) Find all students whose name starts with a vowel
            
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var results =
                from s in students
                where s.Name.ToLower().IndexOfAny(vowel) == 0
                select s;
            List<Student> vowelNames = results.ToList();
            Console.WriteLine("Students whose name starts with a vowel:");
            foreach (Student s in vowelNames)
            {
                Console.WriteLine(s.Name);
            }
            //Console.WriteLine("Find the oldest Student:");
            //Student s = students.OrderByDescending(x => x.Age).First();
            //Console.WriteLine(s.Name);


        }

    }
}

