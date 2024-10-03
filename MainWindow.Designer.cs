namespace KadrowaApp2
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.btnEditHours = new System.Windows.Forms.Button();
            this.btnShowSalary = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(27, 70);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(375, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Dodaj Pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(27, 99);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(375, 23);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edytuj Pracownika";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(27, 128);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(375, 23);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Usuń Pracownika";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(27, 157);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(375, 23);
            this.btnAddHours.TabIndex = 3;
            this.btnAddHours.Text = "Dodaj Przepracowane Godziny";
            this.btnAddHours.UseVisualStyleBackColor = true;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // btnEditHours
            // 
            this.btnEditHours.Location = new System.Drawing.Point(27, 186);
            this.btnEditHours.Name = "btnEditHours";
            this.btnEditHours.Size = new System.Drawing.Size(375, 23);
            this.btnEditHours.TabIndex = 4;
            this.btnEditHours.Text = "Edytuj Przepracowane Godziny";
            this.btnEditHours.UseVisualStyleBackColor = true;
            this.btnEditHours.Click += new System.EventHandler(this.btnEditHours_Click);
            // 
            // btnShowSalary
            // 
            this.btnShowSalary.Location = new System.Drawing.Point(27, 215);
            this.btnShowSalary.Name = "btnShowSalary";
            this.btnShowSalary.Size = new System.Drawing.Size(375, 23);
            this.btnShowSalary.TabIndex = 6;
            this.btnShowSalary.Text = "Pokaż wypłatę pracownika";
            this.btnShowSalary.UseVisualStyleBackColor = true;
            this.btnShowSalary.Click += new System.EventHandler(this.btnShowSalary_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppName.Location = new System.Drawing.Point(98, 7);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(253, 29);
            this.AppName.TabIndex = 7;
            this.AppName.Text = "PolElektronika kadry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 244);
            this.button1.Name = "btnShowAllSalaries";
            this.button1.Size = new System.Drawing.Size(375, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wypłaty wszystkich pracowników";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowAllSalaries_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(429, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.btnShowSalary);
            this.Controls.Add(this.btnEditHours);
            this.Controls.Add(this.btnAddHours);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Form1";
            this.Text = "PolElektronika Kadry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Button btnEditHours;
        private System.Windows.Forms.Button btnShowSalary;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button button1;
    }
}
    #region Kod generowany przez Projektanta formularzy systemu Windows

    /// <summary>
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
    /// jej zawartości w edytorze kodu.
    /// </summary>
    

        #endregion


