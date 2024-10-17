using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        int[] Hoursworked { get; set; }


        public Employee(string Firstname, string Lastname, int Age, string Position, int[] Hoursworked)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Age = Age;
            this.Position = Position;
            this.Hoursworked = Hoursworked;
        }

        private int CalculateTotalHours()
        {
            int total = 0;
            foreach (var hours in Hoursworked)
            {
                total += hours;
            }
            return total;
        }

        private double Hourlyincome()
        {
            if(Position.ToLower() == "manager")
            { return 40; }

            else if (Position.ToLower() == "developer")
            { return 30; }

            else if (Position.ToLower() == "tester")
            { return 20; }

            else { return 10; }
        }


        public double Calculateweeklyincome()
        {
            double totalincome = 0;
            int totalhours = CalculateTotalHours();

            for (int i = 0; i < Hoursworked.Length; i++)
            {
                double hourlyrate = Hourlyincome(); // shefasdeba poziciidan gamomdinare anazgaureba

                if (i < 5) // Weekdays
                {
                    totalincome += Hoursworked[i] * hourlyrate;
                }

                else // Weekend
                {
                    totalincome += Hoursworked[i] * (hourlyrate * 2);
                }
            }

            
            // calculate overtime
            for (int i = 0;i < Hoursworked.Length; i++)
            {
                if (Hoursworked[i] > 8)
                {
                    totalincome += (Hoursworked[i] - 8) * 5;
                }
            }

            // calculate if totalhours in week > 50
            if (totalhours > 50)
            {
                totalincome *= 1.2; // + 20% bonus
            }

            return totalincome;
            
        }

        public double Calculateavarageweeklyincome()
        {
            double avarageweekly = Calculateweeklyincome();
            return avarageweekly / 7;
        }
        
       
    }
}
