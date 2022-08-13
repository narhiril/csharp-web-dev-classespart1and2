using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float CreditHours { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; }

        public Course(string name, string description, float creditHours, Teacher instructor)
        {
            Name = name;
            Description = description;
            Instructor = instructor;
            CreditHours = creditHours;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMultipleStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                this.AddStudent(student);
            }
        }

    }
}
