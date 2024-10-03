using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KadrowaApp2
{
    public partial class ShowAllSalariesForm : Form
    {
        private List<Employee> employees;
        public ShowAllSalariesForm(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            DisplaySalariesInfo();
        }

        private void DisplaySalariesInfo()
        {
            double grossSalary = 0;
            double netSalary = 0;
            double employerCost = 0;
            double socialSecurity = 0;
            double healthInsurance = 0;
            foreach (var employee in employees)
            {
                grossSalary += employee.CalculateGrossSalary();
                netSalary += employee.CalculateNetSalary();
                employerCost += employee.CalculateEmployerCost();
                socialSecurity += employee.CalculateSocialSecurity();
                healthInsurance += employee.CalculateHealthInsurance();
            }
            

            lblGrossSalary.Text = $"Wypłaty brutto: {grossSalary:C}";
            lblNetSalary.Text = $"Wypłaty netto: {netSalary:C}";
            lblEmployerCost.Text = $"Koszt pracodawcy: {employerCost:C}";
            lblSocialSecurity.Text = $"Składki do ZUS: {socialSecurity:C}";
            lblHealthInsurance.Text = $"Ubezpieczenie zdrowotne: {healthInsurance:C}";
        }
    }
}
