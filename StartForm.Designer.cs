namespace KadrowaApp2
{
    partial class StartForm
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
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(75, 86);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(150, 23);
            this.btnNewFile.TabIndex = 0;
            this.btnNewFile.Text = "Nowy Plik";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(75, 115);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(150, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Wczytaj Plik";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppName.Location = new System.Drawing.Point(21, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(253, 29);
            this.AppName.TabIndex = 8;
            this.AppName.Text = "PolElektronika kadry";
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnNewFile);
            this.Name = "StartForm";
            this.Text = "PolElektronika kadry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label AppName;
    }
}
