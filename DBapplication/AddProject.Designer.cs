namespace DBapplication
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_PName = new System.Windows.Forms.TextBox();
            this.Txt_PNumber = new System.Windows.Forms.TextBox();
            this.Txt_PLocation = new System.Windows.Forms.TextBox();
            this.ComboBox_DName = new System.Windows.Forms.ComboBox();
            this.Btn_AddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Name";
            // 
            // Txt_PName
            // 
            this.Txt_PName.Location = new System.Drawing.Point(180, 53);
            this.Txt_PName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_PName.Name = "Txt_PName";
            this.Txt_PName.Size = new System.Drawing.Size(160, 22);
            this.Txt_PName.TabIndex = 4;
            // 
            // Txt_PNumber
            // 
            this.Txt_PNumber.Location = new System.Drawing.Point(180, 101);
            this.Txt_PNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_PNumber.Name = "Txt_PNumber";
            this.Txt_PNumber.Size = new System.Drawing.Size(160, 22);
            this.Txt_PNumber.TabIndex = 5;
            // 
            // Txt_PLocation
            // 
            this.Txt_PLocation.Location = new System.Drawing.Point(180, 153);
            this.Txt_PLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_PLocation.Name = "Txt_PLocation";
            this.Txt_PLocation.Size = new System.Drawing.Size(160, 22);
            this.Txt_PLocation.TabIndex = 6;
            // 
            // ComboBox_DName
            // 
            this.ComboBox_DName.FormattingEnabled = true;
            this.ComboBox_DName.Location = new System.Drawing.Point(180, 217);
            this.ComboBox_DName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_DName.Name = "ComboBox_DName";
            this.ComboBox_DName.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_DName.TabIndex = 7;
            this.ComboBox_DName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_DName_SelectedIndexChanged);
            // 
            // Btn_AddProject
            // 
            this.Btn_AddProject.Location = new System.Drawing.Point(153, 281);
            this.Btn_AddProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AddProject.Name = "Btn_AddProject";
            this.Btn_AddProject.Size = new System.Drawing.Size(100, 28);
            this.Btn_AddProject.TabIndex = 8;
            this.Btn_AddProject.Text = "Add Project";
            this.Btn_AddProject.UseVisualStyleBackColor = true;
            this.Btn_AddProject.Click += new System.EventHandler(this.Btn_AddProject_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 341);
            this.Controls.Add(this.Btn_AddProject);
            this.Controls.Add(this.ComboBox_DName);
            this.Controls.Add(this.Txt_PLocation);
            this.Controls.Add(this.Txt_PNumber);
            this.Controls.Add(this.Txt_PName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_PName;
        private System.Windows.Forms.TextBox Txt_PNumber;
        private System.Windows.Forms.TextBox Txt_PLocation;
        private System.Windows.Forms.ComboBox ComboBox_DName;
        private System.Windows.Forms.Button Btn_AddProject;
    }
}