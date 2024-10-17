using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9._1
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int EnrollmentYear {  get; set; }

        public Student(string Name, int Age, int EnrollmentYear)
        {
            this.Name = Name;
            this.Age = Age;
            this.EnrollmentYear = EnrollmentYear;
        }

        public string RandomSubjects()
        {
            string[] Subjects = { "Math", "Science", "English", "Chemistry" };
            Random rand = new Random();
            string Returned = Subjects[rand.Next(Subjects.Length)];
            return Returned;
        }

        public int YearsLeft()
        {
            int yearsleft = 4 - (DateTime.Now.Year - EnrollmentYear);
            return yearsleft;
        }
    }
}
