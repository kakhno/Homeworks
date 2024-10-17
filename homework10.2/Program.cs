using homework10._2;
using System;

class Program
{
    static void Main(string[] args)
    {
        var bank = new Bank();
        var microfinance = new MicroFinance();

        Console.Write("Please enter which do you want -- Bank or MicroFinance: ");
        string WhichSystem = Console.ReadLine();

        if (WhichSystem.ToLower() == "bank")
        {
            if (!bank.CheckUserHistory())
            {
                Console.WriteLine("False User History");
            }
            else
            {
                Console.WriteLine("True User History");

                Console.Write("Please enter amount of gel: ");
                bank.TotalAmount = int.Parse(Console.ReadLine());

                Console.Write("Please enter amount of month: ");
                bank.Month = int.Parse(Console.ReadLine());

                Console.Write("Please enter percentage(0.05 = 5%): ");
                bank.AmountPerMonth = double.Parse(Console.ReadLine());

                Console.Write("Total amount to pay: ");
                bank.CalculateLoanPercent(bank.Month, bank.AmountPerMonth);
            }
        }
            else if (WhichSystem.ToLower() == "microfinance")
            {
                Console.Write("Please enter amount of gel: ");
                microfinance.TotalAmount = int.Parse(Console.ReadLine());

                Console.Write("Please enter amount of month: ");
                microfinance.Month = int.Parse(Console.ReadLine());

                Console.Write("Please enter percentage(0.1 = 10%): ");
                microfinance.AmountPerMonth = double.Parse(Console.ReadLine());

                Console.Write("Total amount to pay: ");
                microfinance.CalculateLoanPercent(microfinance.Month, microfinance.AmountPerMonth);
            }

        }        
    }

