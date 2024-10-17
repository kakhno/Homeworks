using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Company
    {
        public string type {  get; set; }

        public Company(string type) 
        {
            this.type = type;
        }

        public double Calculatetax(double income)
        {
            double tax = 0; 

            if (type == "local")
            {
                tax = income * 0.18; // 18% tax for local
            }
            else if (type == "foreign")
            {
                tax = income * 0.05; // 5% tax for foreign
            }
            return tax; 
        }

    }
}
