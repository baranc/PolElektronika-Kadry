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
    public partial class AddWorkedHoursForm : Form
    {
        public Employee EditedEmployee { get; private set; }
        public AddWorkedHoursForm(Employee employee)
        {
            EditedEmployee = employee;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tutaj możesz dodać walidację danych, na przykład sprawdzanie, czy pola są wypełnione poprawnie
            if (double.TryParse(txtWorkedHours.Text, out var parsedWorkedHours))
            {
                EditedEmployee.WorkedHours += parsedWorkedHours;
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
