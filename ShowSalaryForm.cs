using System;
using System.Windows.Forms;

namespace KadrowaApp2
{
    public partial class ShowSalaryForm : Form
    {
        public ShowSalaryForm(Employee employee)
        {
            InitializeComponent();
            DisplaySalaryInfo(employee);
            this.Text = $"Wypłata dla {employee.FirstName} {employee.LastName}";
        }

        private void DisplaySalaryInfo(Employee employee)
        {
            double grossSalary = employee.CalculateGrossSalary();
            double netSalary = employee.CalculateNetSalary();
            double employerCost = employee.CalculateEmployerCost();
            double socialSecurity = employee.CalculateSocialSecurity();
            double healthInsurance = employee.CalculateHealthInsurance();

            lblGrossSalary.Text = $"Wypłata brutto: {grossSalary:C}";
            lblNetSalary.Text = $"Wypłata netto: {netSalary:C}";
            lblEmployerCost.Text = $"Koszt pracodawcy: {employerCost:C}";
            lblSocialSecurity.Text = $"Składka do ZUS: {socialSecurity:C}";
            lblHealthInsurance.Text = $"Ubezpieczenie zdrowotne: {healthInsurance:C}";
        }
    }
}
