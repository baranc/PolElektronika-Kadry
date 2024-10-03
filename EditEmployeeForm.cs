using System;
using System.Windows.Forms;

namespace KadrowaApp2
{
    public partial class EditEmployeeForm : Form
    {
        public Employee EditedEmployee { get; private set; }

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            EditedEmployee = employee;
            InitializeFormData();
        }

        private void InitializeFormData()
        {
            txtFirstName.Text = EditedEmployee.FirstName;
            txtLastName.Text = EditedEmployee.LastName;
            dtpDateOfBirth.Value = EditedEmployee.DateOfBirth;
            txtPesel.Text = EditedEmployee.Pesel;
            txtHourlyRate.Text = EditedEmployee.GrossHourlyRate.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tutaj możesz dodać walidację danych, na przykład sprawdzanie, czy pola są wypełnione poprawnie
            EditedEmployee.FirstName = txtFirstName.Text;
            EditedEmployee.LastName = txtLastName.Text;
            EditedEmployee.DateOfBirth = dtpDateOfBirth.Value;
            EditedEmployee.Pesel = txtPesel.Text;
            if(double.TryParse(txtHourlyRate.Text, out var parsedHourlyRate ))
            {
                EditedEmployee.GrossHourlyRate = parsedHourlyRate;
            }
            

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
