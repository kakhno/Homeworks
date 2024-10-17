using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10._2
{
    interface IFinanceOperations
    {
        void CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();

    }

    //  BANK CLASS ------------ 
    internal class Bank : IFinanceOperations
    {
        public int TotalAmount { get; set; }
        public double AmountPerMonth { get; set; }
        public int Month { get; set; }

        public void CalculateLoanPercent(int month, double AmountPerMonth)
        {
            Console.WriteLine((month * (TotalAmount * AmountPerMonth)) + TotalAmount);
            // itvlis jamshi ramdenis gadaxda mouwevs
        }

        public bool CheckUserHistory()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }
    }


    // MICROFINANCE CLASS -----------------
    internal class MicroFinance : IFinanceOperations
    {
        public int TotalAmount { get; set; }
        public double AmountPerMonth { get; set; }
        public int Month { get; set; }
        public void CalculateLoanPercent(int month, double AmountPerMonth)
        {
            Console.WriteLine((month * (TotalAmount * AmountPerMonth)) + TotalAmount + month * 4);
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
