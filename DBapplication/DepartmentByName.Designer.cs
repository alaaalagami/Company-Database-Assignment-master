namespace DBapplication
{
    partial class DepartmentByName
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.empCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(172, 311);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(108, 58);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "Retrieve";
            this.calculateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Projects";
            // 
            // empCountLabel
            // 
            this.empCountLabel.AutoSize = true;
            this.empCountLabel.Location = new System.Drawing.Point(228, 92);
            this.empCountLabel.Name = "empCountLabel";
            this.empCountLabel.Size = new System.Drawing.Size(51, 20);
            this.empCountLabel.TabIndex = 10;
            this.empCountLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Employees";
            // 
            // comboBoxDName
            // 
            this.comboBoxDName.FormattingEnabled = true;
            this.comboBoxDName.Location = new System.Drawing.Point(232, 28);
            this.comboBoxDName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDName.Name = "comboBoxDName";
            this.comboBoxDName.Size = new System.Drawing.Size(172, 28);
            this.comboBoxDName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Department Name";
            // 
            // projectsList
            // 
            this.projectsList.FormattingEnabled = true;
            this.projectsList.ItemHeight = 20;
            this.projectsList.Location = new System.Drawing.Point(232, 154);
            this.projectsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectsList.Name = "projectsList";
            this.projectsList.Size = new System.Drawing.Size(172, 124);
            this.projectsList.TabIndex = 14;
            this.projectsList.SelectedIndexChanged += new System.EventHandler(this.projectsList_SelectedIndexChanged);
            // 
            // DepartmentByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 384);
            this.Controls.Add(this.projectsList);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DepartmentByName";
            this.Text = "DepartmentByName";
            this.Load += new System.EventHandler(this.DepartmentByName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label empCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox projectsList;
    }
}