using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; } = 0d;

        public Student(string name, int id, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = id;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int id) : this(name, id, 0, 0d) { }
    }
}
