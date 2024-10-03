using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadrowaApp2
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public double GrossHourlyRate { get; set; }
        public double WorkedHours { get; set; }
        public double CalculateGrossSalary()
        {
            return GrossHourlyRate * WorkedHours;
        }

        public double CalculateNetSalary()
        {
            double grossSalary = CalculateGrossSalary();
            double socialSecurity = grossSalary * 0.0976;
            double healthInsurance = grossSalary * 0.09;
            double tax;
            if (grossSalary <= 2500)
            {
                tax = 0;
            }
            else if(grossSalary<=10000 && grossSalary > 2500)
            {
                tax = (grossSalary - 2500) * 0.12 ;
            }
            else 
            {
                tax = 0.12 * (10000 - 2500) + 0.32 * (grossSalary - 10000); 
            }
            
            return grossSalary - socialSecurity - healthInsurance - tax;
        }

        public double CalculateEmployerCost()
        {
            double grossSalary = CalculateGrossSalary();
            double employerSocialSecurity = grossSalary * 0.1952;
            return grossSalary + employerSocialSecurity;
        }

        public double CalculateSocialSecurity()
        {
            return CalculateGrossSalary() * 0.0976;
        }

        public double CalculateHealthInsurance()
        {
            return CalculateGrossSalary() * 0.09;
        }
    }
}
