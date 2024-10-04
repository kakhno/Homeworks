using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Task3");
            Console.WriteLine("---------");

            Console.WriteLine("Enter a number: ");
            var arraysize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter list numbers (space-separated): ");
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var freq = from num in input
                       group num by num into output
                       select output;

            Console.WriteLine("Quantity: ");

            foreach (var number in freq)
            {
                int count = number.Count();
                int sum = number.Sum();
                Console.WriteLine($"{number.Key} appears {count} times for a total of {sum}");
            }
        }
    }
}
