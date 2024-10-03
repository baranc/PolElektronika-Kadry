using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KadrowaApp2
{

    public partial class MainWindow : Form
    {
        private int nextId;
        private List<Employee> employees;
        private String filePath;
        public MainWindow(string filePath)
        {
            this.filePath = filePath;
            InitializeComponent();
            LoadEmployeesFromFile();
        }

        private void LoadEmployeesFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                employees = JsonSerializer.Deserialize<List<Employee>>(json);
                if (employees != null && employees.Count > 0)
                {
                    nextId = employees[employees.Count - 1].ID + 1;
                }
                else
                {
                    employees = new List<Employee>();
                    nextId = 1;
                }
            }
            else
            {
                employees = new List<Employee>();
                nextId = 1;
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm addEmployeeForm = new AddEmployeeForm())
            {
                if (addEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    addEmployeeForm.NewEmployee.ID = nextId++;
                    employees.Add(addEmployeeForm.NewEmployee);
                    SaveEmployeesToFile();
                }
            }
        }

        private void SaveEmployeesToFile()
        {
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            MessageBox.Show("Plik został zapisany.");
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (employees.Count == 0)
            {
                MessageBox.Show("Brak pracowników do edycji.");
                return;
            }

            using (SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(employees))
            {
                if (selectEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    Employee selectedEmployee = selectEmployeeForm.SelectedEmployee;
                    using (EditEmployeeForm editEmployeeForm = new EditEmployeeForm(selectedEmployee))
                    {
                        if (editEmployeeForm.ShowDialog() == DialogResult.OK)
                        {
                            // Zapisz zmienionego pracownika do listy i pliku
                            int index = employees.FindIndex(emp => emp.ID == selectedEmployee.ID);
                            employees[index] = editEmployeeForm.EditedEmployee;
                            SaveEmployeesToFile();
                        }
                    }
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (employees.Count == 0)
            {
                MessageBox.Show("Brak pracowników do usunięcia.");
                return;
            }

            using (SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(employees))
            {
                if (selectEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    Employee selectedEmployee = selectEmployeeForm.SelectedEmployee;
                    employees.Remove(selectedEmployee);
                    MessageBox.Show("Pracownik został usunięty.");
                    SaveEmployeesToFile();

                }
            }
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            using (SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(employees))
            {
                if (selectEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    Employee selectedEmployee = selectEmployeeForm.SelectedEmployee;
                    using (AddWorkedHoursForm addWorkedHoursForm = new AddWorkedHoursForm(selectedEmployee))
                    {
                        if (addWorkedHoursForm.ShowDialog() == DialogResult.OK)
                        {
                            int index = employees.FindIndex(emp => emp.ID == selectedEmployee.ID);
                            employees[index] = addWorkedHoursForm.EditedEmployee;
                            SaveEmployeesToFile();
                        }
                    }

                }
            }
        }

        private void btnEditHours_Click(object sender, EventArgs e)
        {
            using (SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(employees))
            {
                if (selectEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    Employee selectedEmployee = selectEmployeeForm.SelectedEmployee;
                    using (EditWorkedHoursForm editWorkedHoursForm = new EditWorkedHoursForm(selectedEmployee))
                    {
                        if (editWorkedHoursForm.ShowDialog() == DialogResult.OK)
                        {
                            int index = employees.FindIndex(emp => emp.ID == selectedEmployee.ID);
                            employees[index] = editWorkedHoursForm.EditedEmployee;
                            SaveEmployeesToFile();
                        }
                    }

                }
            }
        }


        private void btnShowSalary_Click(object sender, EventArgs e)
        {
            using (SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(employees))
            {
                if (selectEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    Employee selectedEmployee = selectEmployeeForm.SelectedEmployee;
                    using (ShowSalaryForm showSalaryForm = new ShowSalaryForm(selectedEmployee))
                    {
                        showSalaryForm.ShowDialog();
                    }
                }
            }
        }
        private void btnShowAllSalaries_Click(object sender, EventArgs e)
        {
            using (ShowAllSalariesForm showAllSalariesForm = new ShowAllSalariesForm(employees))
            {
                showAllSalariesForm.ShowDialog();
            }
        }
    }
}    

