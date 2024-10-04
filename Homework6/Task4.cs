using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Task4
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of top participants you want to see: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the list of participants (space-separated): ");
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var topParticipants = input.OrderByDescending(x => x).Take(n);

            Console.WriteLine("Top participants:");
            Console.WriteLine(string.Join(" ", topParticipants));
        }
    }
}