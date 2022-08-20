using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Anna", 1, 4d);
            Console.WriteLine(student.ToString());
        }
    }
}
