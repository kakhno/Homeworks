using homework9;
using System;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // COMPANY ---------------

        while (true)
        {

            Console.Write("Enter company type (local/foreign): ");
            string type = Console.ReadLine();

            if (type != "local" && type != "foreign")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong type");
                Console.ResetColor();
            }
            else
            {

                var company = new Company(type);


                // EMPLOYEE ---------------
                Console.Write("Enter employee name: ");
                string Firstname = Console.ReadLine();

                Console.Write("Enter employee lastname: ");
                string Lastname = Console.ReadLine();

                Console.Write("Enter employee age: ");
                int Age = int.Parse(Console.ReadLine());

                Console.Write("Enter employee position (manager/developer/tester/other): ");
                string Position = Console.ReadLine();

                Console.Write("Enter hours worked during the week (comma-separated): ");
                string hoursinput = Console.ReadLine();
                int[] hoursWorked = Array.ConvertAll(hoursinput.Split(','), int.Parse);

                Console.WriteLine();
                Console.WriteLine();

                var employee = new Employee(Firstname, Lastname, Age, Position, hoursWorked);

                double weeklysalary = employee.Calculateweeklyincome();

                double avarageweeklyincome = employee.Calculateavarageweeklyincome();
                Console.Write($"Avarage weekly income for {employee.Firstname} is: {weeklysalary}");

                Console.WriteLine();
                Console.WriteLine();


                double calculatetax = employee.Calculateweeklyincome();

                double tax = company.Calculatetax(calculatetax);
                Console.Write($"Tax to be paid: {Math.Round(tax, 2)}");


                Console.WriteLine();
                Console.WriteLine();

                double totalsalary = employee.Calculateweeklyincome() - tax;
                Console.Write($"Total salary: {Math.Round(totalsalary, 2)}");


                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}