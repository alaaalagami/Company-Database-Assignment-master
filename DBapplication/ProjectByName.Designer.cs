namespace DBapplication
{
    partial class ProjectByName
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
            this.comboBoxPName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // comboBoxPName
            // 
            this.comboBoxPName.FormattingEnabled = true;
            this.comboBoxPName.Location = new System.Drawing.Point(241, 39);
            this.comboBoxPName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPName.Name = "comboBoxPName";
            this.comboBoxPName.Size = new System.Drawing.Size(172, 28);
            this.comboBoxPName.TabIndex = 1;
            this.comboBoxPName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Employees";
            // 
            // empCountLabel
            // 
            this.empCountLabel.AutoSize = true;
            this.empCountLabel.Location = new System.Drawing.Point(241, 112);
            this.empCountLabel.Name = "empCountLabel";
            this.empCountLabel.Size = new System.Drawing.Size(51, 20);
            this.empCountLabel.TabIndex = 3;
            this.empCountLabel.Text = "label3";
            this.empCountLabel.Click += new System.EventHandler(this.empCountLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Hours Spent";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(237, 180);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(51, 20);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "label5";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(344, 220);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(108, 58);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Retrieve";
            this.calculateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // ProjectByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 292);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectByName";
            this.Text = "ProjectByName";
            this.Load += new System.EventHandler(this.ProjectByName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label empCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button calculateBtn;
    }
}