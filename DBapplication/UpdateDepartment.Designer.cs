namespace DBapplication
{
    partial class UpdateDepartment
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
            this.retrieveBtn = new System.Windows.Forms.Button();
            this.comboBoxDName = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.Txt_MgrSSN = new System.Windows.Forms.TextBox();
            this.Txt_DNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Location = new System.Drawing.Point(319, 16);
            this.retrieveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(100, 24);
            this.retrieveBtn.TabIndex = 29;
            this.retrieveBtn.Text = "Retrieve";
            this.retrieveBtn.UseVisualStyleBackColor = true;
            this.retrieveBtn.Click += new System.EventHandler(this.retrieveBtn_Click);
            // 
            // comboBoxDName
            // 
            this.comboBoxDName.FormattingEnabled = true;
            this.comboBoxDName.Location = new System.Drawing.Point(143, 16);
            this.comboBoxDName.Name = "comboBoxDName";
            this.comboBoxDName.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDName.TabIndex = 28;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(158, 265);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Txt_MgrSSN
            // 
            this.Txt_MgrSSN.Location = new System.Drawing.Point(191, 136);
            this.Txt_MgrSSN.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_MgrSSN.Name = "Txt_MgrSSN";
            this.Txt_MgrSSN.Size = new System.Drawing.Size(160, 22);
            this.Txt_MgrSSN.TabIndex = 25;
            // 
            // Txt_DNumber
            // 
            this.Txt_DNumber.Location = new System.Drawing.Point(191, 80);
            this.Txt_DNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DNumber.Name = "Txt_DNumber";
            this.Txt_DNumber.Size = new System.Drawing.Size(160, 22);
            this.Txt_DNumber.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Manager Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manager SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Department Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department Name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(191, 199);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker.TabIndex = 30;
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 306);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.comboBoxDName);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.Txt_MgrSSN);
            this.Controls.Add(this.Txt_DNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDepartment";
            this.Text = "UpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrieveBtn;
        private System.Windows.Forms.ComboBox comboBoxDName;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox Txt_MgrSSN;
        private System.Windows.Forms.TextBox Txt_DNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}