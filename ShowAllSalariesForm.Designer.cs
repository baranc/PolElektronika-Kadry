namespace KadrowaApp2
{
    partial class ShowAllSalariesForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblEmployerCost = new System.Windows.Forms.Label();
            this.lblSocialSecurity = new System.Windows.Forms.Label();
            this.lblHealthInsurance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Location = new System.Drawing.Point(12, 20);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(0, 16);
            this.lblGrossSalary.TabIndex = 0;
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Location = new System.Drawing.Point(12, 50);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(0, 16);
            this.lblNetSalary.TabIndex = 1;
            // 
            // lblEmployerCost
            // 
            this.lblEmployerCost.AutoSize = true;
            this.lblEmployerCost.Location = new System.Drawing.Point(12, 80);
            this.lblEmployerCost.Name = "lblEmployerCost";
            this.lblEmployerCost.Size = new System.Drawing.Size(0, 16);
            this.lblEmployerCost.TabIndex = 2;
            // 
            // lblSocialSecurity
            // 
            this.lblSocialSecurity.AutoSize = true;
            this.lblSocialSecurity.Location = new System.Drawing.Point(12, 110);
            this.lblSocialSecurity.Name = "lblSocialSecurity";
            this.lblSocialSecurity.Size = new System.Drawing.Size(0, 16);
            this.lblSocialSecurity.TabIndex = 3;
            // 
            // lblHealthInsurance
            // 
            this.lblHealthInsurance.AutoSize = true;
            this.lblHealthInsurance.Location = new System.Drawing.Point(12, 140);
            this.lblHealthInsurance.Name = "lblHealthInsurance";
            this.lblHealthInsurance.Size = new System.Drawing.Size(0, 16);
            this.lblHealthInsurance.TabIndex = 4;
            // 
            // ShowSalaryForm
            // 
            this.ClientSize = new System.Drawing.Size(367, 200);
            this.Controls.Add(this.lblHealthInsurance);
            this.Controls.Add(this.lblSocialSecurity);
            this.Controls.Add(this.lblEmployerCost);
            this.Controls.Add(this.lblNetSalary);
            this.Controls.Add(this.lblGrossSalary);
            this.Name = "ShowAllSalariesForm";
            this.Text = "Wypłaty dla pracowników";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblEmployerCost;
        private System.Windows.Forms.Label lblSocialSecurity;
        private System.Windows.Forms.Label lblHealthInsurance;
    }
}
