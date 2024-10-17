using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9._1
{
    internal class Teacher
    {
        public string Name { get; set; }
        public bool IsCertified { get; set; }

        public Teacher(string Name, bool IsCertified)
        {
            this.Name = Name;
            this.IsCertified = IsCertified;
        }


        public string TeachSubject(string subject)
        {
            Random rand = new Random();

            if (subject.ToLower() == "math")
            {
                int num1 = rand.Next(1, 101);
                int num2 = rand.Next(1, 101);
                return $"The sum of {num1} and {num2} is {num1 + num2}.";
            }
            else if (subject.ToLower() == "chemistry")
            {
                return "H2O is water";
            }
            else if (subject.ToLower() == "english")
            {
                return "Hello World";
            }
            else
            {
                return "He is not competent in this subject.";
            }
        }
    }
}
