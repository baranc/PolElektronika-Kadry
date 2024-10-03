using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KadrowaApp2
{
    public partial class SelectEmployeeForm : Form
    {
        private List<Employee> employees;
        public Employee SelectedEmployee { get; private set; }

        public SelectEmployeeForm(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            PopulateEmployeeList(employees);
        }

        private void PopulateEmployeeList(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                lbEmployees.Items.Add($"{employee.FirstName} {employee.LastName}");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedItem != null)
            {
                // Pobierz indeks wybranego pracownika na liście
                int selectedIndex = lbEmployees.SelectedIndex;
                // Pobierz pracownika z listy na podstawie indeksu
                SelectedEmployee = employees[selectedIndex];
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Wybierz pracownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
