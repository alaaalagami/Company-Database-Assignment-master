namespace DBapplication
{
    partial class SalarySearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnteredSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompareComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.ItemHeight = 20;
            this.EmployeesList.Location = new System.Drawing.Point(60, 259);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(156, 184);
            this.EmployeesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary:";
            // 
            // EnteredSalary
            // 
            this.EnteredSalary.Location = new System.Drawing.Point(197, 52);
            this.EnteredSalary.Name = "EnteredSalary";
            this.EnteredSalary.Size = new System.Drawing.Size(121, 26);
            this.EnteredSalary.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display Salaries";
            // 
            // CompareComboBox
            // 
            this.CompareComboBox.FormattingEnabled = true;
            this.CompareComboBox.Items.AddRange(new object[] {
            "Equal To",
            "Not Equal To",
            "Less Than",
            "Greater Than"});
            this.CompareComboBox.Location = new System.Drawing.Point(197, 120);
            this.CompareComboBox.Name = "CompareComboBox";
            this.CompareComboBox.Size = new System.Drawing.Size(121, 28);
            this.CompareComboBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(60, 183);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(106, 38);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Display";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SalarySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 455);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CompareComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnteredSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeesList);
            this.Name = "SalarySearch";
            this.Text = "SalarySearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnteredSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CompareComboBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}