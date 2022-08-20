using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int NextId { get; set; } = 1;
        public string Name { get; set; }
        public int StudentId { get; private set; }
        public int NumberOfCredits { get; private set; }
        public double Gpa { get; private set; }

        public Student(string name, int numberOfCredits = 0, double gpa = 0d)
        {
            Name = name;
            StudentId = Student.NextId;
            Student.NextId++;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public string GetGradeLevel()
        {
            return this.NumberOfCredits < 30 ? "Freshman" :
                   this.NumberOfCredits < 60 ? "Sophomore" :
                   this.NumberOfCredits < 90 ? "Junior" :
                   "Senior";
        }

        public void AddGrade(int creditHours, double grade)
        {
            //sanity checks
            if (creditHours < 0)
            {
                throw new ArgumentOutOfRangeException("AddGrade: creditHours cannot be negative!");
            } 
            else if (grade < 0d || grade > 4.0d)
            {
                throw new ArgumentOutOfRangeException("AddGrade: grade must be between 0.0 and 4.0!");
            }

            this.UpdateGpa(creditHours, grade);
            this.NumberOfCredits += creditHours; //must be AFTER call to UpdateGpa
        }

        private void UpdateGpa(int creditHours, double grade)
        {
            {
                if (this.NumberOfCredits == 0 && grade == 0) //prevents possible division by 0
                {
                    return;
                }
                else
                {
                    double currentQualityScore = this.Gpa * this.NumberOfCredits;
                    double newQualityScore = currentQualityScore + creditHours * grade;
                    this.Gpa = newQualityScore / (this.NumberOfCredits + creditHours);
                }
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
                Student theStudent = obj as Student;
                return theStudent.StudentId == this.StudentId;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.GetGradeLevel()})" + Environment.NewLine +
                   $"Student #{this.StudentId}" + Environment.NewLine +
                   $"{this.NumberOfCredits} credit hours completed" + Environment.NewLine +
                   $"{this.Gpa} GPA";

        }

        public override int GetHashCode()
        {
            unchecked
            {
                return 11017957 * this.StudentId.GetHashCode();
            }
        }
    }
}
