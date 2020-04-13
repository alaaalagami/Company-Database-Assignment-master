namespace DBapplication
{
    partial class UpdateProject
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
            this.comboBoxDName = new System.Windows.Forms.ComboBox();
            this.Txt_PLocation = new System.Windows.Forms.TextBox();
            this.Txt_PNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPName = new System.Windows.Forms.ComboBox();
            this.retrieveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_AddProject
            // 
            this.Btn_AddProject.Location = new System.Drawing.Point(147, 248);
            this.Btn_AddProject.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddProject.Name = "Btn_AddProject";
            this.Btn_AddProject.Size = new System.Drawing.Size(100, 28);
            this.Btn_AddProject.TabIndex = 17;
            this.Btn_AddProject.Text = "Save";
            this.Btn_AddProject.UseVisualStyleBackColor = true;
            this.Btn_AddProject.Click += new System.EventHandler(this.Btn_AddProject_Click);
            // 
            // comboBoxDName
            // 
            this.comboBoxDName.FormattingEnabled = true;
            this.comboBoxDName.Location = new System.Drawing.Point(191, 193);
            this.comboBoxDName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDName.Name = "comboBoxDName";
            this.comboBoxDName.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDName.TabIndex = 16;
            // 
            // Txt_PLocation
            // 
            this.Txt_PLocation.Location = new System.Drawing.Point(191, 138);
            this.Txt_PLocation.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_PLocation.Name = "Txt_PLocation";
            this.Txt_PLocation.Size = new System.Drawing.Size(160, 22);
            this.Txt_PLocation.TabIndex = 15;
            // 
            // Txt_PNumber
            // 
            this.Txt_PNumber.Location = new System.Drawing.Point(191, 82);
            this.Txt_PNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_PNumber.Name = "Txt_PNumber";
            this.Txt_PNumber.Size = new System.Drawing.Size(160, 22);
            this.Txt_PNumber.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Project Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Name";
            // 
            // comboBoxPName
            // 
            this.comboBoxPName.FormattingEnabled = true;
            this.comboBoxPName.Location = new System.Drawing.Point(124, 17);
            this.comboBoxPName.Name = "comboBoxPName";
            this.comboBoxPName.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPName.TabIndex = 18;
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Location = new System.Drawing.Point(300, 17);
            this.retrieveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(100, 24);
            this.retrieveBtn.TabIndex = 19;
            this.retrieveBtn.Text = "Retrieve";
            this.retrieveBtn.UseVisualStyleBackColor = true;
            this.retrieveBtn.Click += new System.EventHandler(this.retrieveBtn_Click);
            // 
            // UpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 289);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.comboBoxPName);
            this.Controls.Add(this.Btn_AddProject);
            this.Controls.Add(this.comboBoxDName);
            this.Controls.Add(this.Txt_PLocation);
            this.Controls.Add(this.Txt_PNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProject";
            this.Text = "UpdateProject";
            this.Load += new System.EventHandler(this.UpdateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddProject;
        private System.Windows.Forms.ComboBox comboBoxDName;
        private System.Windows.Forms.TextBox Txt_PLocation;
        private System.Windows.Forms.TextBox Txt_PNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPName;
        private System.Windows.Forms.Button retrieveBtn;
    }
}