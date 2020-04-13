namespace DBapplication
{
    partial class AddDepartment
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
            this.Btn_AddProject = new System.Windows.Forms.Button();
            this.ComboBox_MName = new System.Windows.Forms.ComboBox();
            this.Txt_DNumber = new System.Windows.Forms.TextBox();
            this.Txt_DName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_AddProject
            // 
            this.Btn_AddProject.Location = new System.Drawing.Point(146, 285);
            this.Btn_AddProject.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddProject.Name = "Btn_AddProject";
            this.Btn_AddProject.Size = new System.Drawing.Size(124, 28);
            this.Btn_AddProject.TabIndex = 17;
            this.Btn_AddProject.Text = "Add Department";
            this.Btn_AddProject.UseVisualStyleBackColor = true;
            this.Btn_AddProject.Click += new System.EventHandler(this.Btn_AddProject_Click);
            // 
            // ComboBox_MName
            // 
            this.ComboBox_MName.FormattingEnabled = true;
            this.ComboBox_MName.Location = new System.Drawing.Point(181, 153);
            this.ComboBox_MName.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_MName.Name = "ComboBox_MName";
            this.ComboBox_MName.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_MName.TabIndex = 16;
            // 
            // Txt_DNumber
            // 
            this.Txt_DNumber.Location = new System.Drawing.Point(181, 100);
            this.Txt_DNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DNumber.Name = "Txt_DNumber";
            this.Txt_DNumber.Size = new System.Drawing.Size(160, 22);
            this.Txt_DNumber.TabIndex = 14;
            // 
            // Txt_DName
            // 
            this.Txt_DName.Location = new System.Drawing.Point(181, 52);
            this.Txt_DName.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DName.Name = "Txt_DName";
            this.Txt_DName.Size = new System.Drawing.Size(160, 22);
            this.Txt_DName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manager Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manager Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department Name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(44, 226);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker.TabIndex = 18;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 341);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Btn_AddProject);
            this.Controls.Add(this.ComboBox_MName);
            this.Controls.Add(this.Txt_DNumber);
            this.Controls.Add(this.Txt_DName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddProject;
        private System.Windows.Forms.ComboBox ComboBox_MName;
        private System.Windows.Forms.TextBox Txt_DNumber;
        private System.Windows.Forms.TextBox Txt_DName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}