using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Anna", 1, 1, 4d);
            Console.WriteLine($"Student #{student.StudentId}, {student.Name}: {student.NumberOfCredits} credit(s), {student.Gpa} GPA");
        }
    }
}
