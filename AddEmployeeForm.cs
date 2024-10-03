using KadrowaApp2;
using System;
using System.Windows.Forms;

namespace KadrowaApp2
{
    public partial class AddEmployeeForm : Form
    {
        public Employee NewEmployee { get; private set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
            InitializePlaceholders();
        }
        private void InitializePlaceholders()
        {
            SetPlaceholder(txtFirstName, "Imię");
            SetPlaceholder(txtLastName, "Nazwisko");
            SetPlaceholder(txtPesel, "PESEL");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            double parsedHourlyRate;
            double.TryParse(txtHourlyRate.Text, out parsedHourlyRate);


            NewEmployee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value.Date,
                Pesel = txtPesel.Text,
                GrossHourlyRate = parsedHourlyRate
            };
        
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
