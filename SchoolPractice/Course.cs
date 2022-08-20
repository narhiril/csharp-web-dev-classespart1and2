using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; private set; }
        public string Description { get; set; }
        public int CreditHours { get; private set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; }

        public Course(string name, string description, int creditHours, Teacher instructor)
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

        public void AddStudent(List<Student> students)
        {
            foreach (Student individual in students)
            {
                this.AddStudent(individual);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            else if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Course theCourse = obj as Course;
                return this.Name == theCourse.Name && this.CreditHours == theCourse.CreditHours;
            }
        }

        public override string ToString()
        {
            return $"Course: {this.Name}" + Environment.NewLine +
                   $"Credit Hours: {this.CreditHours}" + Environment.NewLine +
                   $"Description: {this.Description}";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 6563;
                hash = hash * 397 * this.CreditHours.GetHashCode();
                hash = hash * 397 * this.Name.GetHashCode();
                return hash;
            }
        }

    }
}
