namespace DBapplication
{
    partial class ViewEmployees
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
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.isManagerCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.uncheckAllButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(13, 41);
            this.employeeListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(252, 244);
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            this.employeeListBox.DoubleClick += new System.EventHandler(this.employeeListBox_DoubleClick);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(16, 337);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 28);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert New";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insetButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(464, 337);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(275, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Options";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 47);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(229, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sex";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Items.AddRange(new object[] {
            "Any",
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(332, 79);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(231, 24);
            this.sexComboBox.TabIndex = 0;
            // 
            // isManagerCheckBox
            // 
            this.isManagerCheckBox.AutoSize = true;
            this.isManagerCheckBox.Location = new System.Drawing.Point(283, 112);
            this.isManagerCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isManagerCheckBox.Name = "isManagerCheckBox";
            this.isManagerCheckBox.Size = new System.Drawing.Size(100, 21);
            this.isManagerCheckBox.TabIndex = 7;
            this.isManagerCheckBox.Text = "Is Manager";
            this.isManagerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "In Department";
            // 
            // departmentCheckedListBox
            // 
            this.departmentCheckedListBox.FormattingEnabled = true;
            this.departmentCheckedListBox.Location = new System.Drawing.Point(283, 172);
            this.departmentCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentCheckedListBox.Name = "departmentCheckedListBox";
            this.departmentCheckedListBox.Size = new System.Drawing.Size(280, 140);
            this.departmentCheckedListBox.TabIndex = 10;
            // 
            // uncheckAllButton
            // 
            this.uncheckAllButton.Location = new System.Drawing.Point(463, 144);
            this.uncheckAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uncheckAllButton.Name = "uncheckAllButton";
            this.uncheckAllButton.Size = new System.Drawing.Size(100, 28);
            this.uncheckAllButton.TabIndex = 11;
            this.uncheckAllButton.Text = "Uncheck All";
            this.uncheckAllButton.UseVisualStyleBackColor = true;
            this.uncheckAllButton.Click += new System.EventHandler(this.uncheckAllButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "* Double-click for more info";
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 380);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uncheckAllButton);
            this.Controls.Add(this.departmentCheckedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isManagerCheckBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.employeeListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.CheckBox isManagerCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox departmentCheckedListBox;
        private System.Windows.Forms.Button uncheckAllButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}