namespace DBapplication
{
    partial class Provided_Functionalities
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
            this.viewEmployeesButton = new System.Windows.Forms.Button();
            this.providedFunctionalitiesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProjectByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getALLProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDepartmentByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getALLDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutButton = new System.Windows.Forms.Button();
            this.salarySearchBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.SalarySearch = new System.Windows.Forms.Button();
            this.providedFunctionalitiesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewEmployeesButton
            // 
            this.viewEmployeesButton.Location = new System.Drawing.Point(86, 72);
            this.viewEmployeesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewEmployeesButton.Name = "viewEmployeesButton";
            this.viewEmployeesButton.Size = new System.Drawing.Size(233, 35);
            this.viewEmployeesButton.TabIndex = 1;
            this.viewEmployeesButton.Text = "View All Employees";
            this.viewEmployeesButton.UseVisualStyleBackColor = true;
            this.viewEmployeesButton.Click += new System.EventHandler(this.viewEmployeesButton_Click);
            // 
            // providedFunctionalitiesMenuStrip
            // 
            this.providedFunctionalitiesMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.providedFunctionalitiesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.providedFunctionalitiesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.providedFunctionalitiesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.providedFunctionalitiesMenuStrip.Name = "providedFunctionalitiesMenuStrip";
            this.providedFunctionalitiesMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.providedFunctionalitiesMenuStrip.Size = new System.Drawing.Size(400, 33);
            this.providedFunctionalitiesMenuStrip.TabIndex = 3;
            this.providedFunctionalitiesMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.departmentsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.retrieveProjectsToolStripMenuItem,
            this.getProjectByNameToolStripMenuItem,
            this.getALLProjectsToolStripMenuItem,
            this.updateProjectToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // retrieveProjectsToolStripMenuItem
            // 
            this.retrieveProjectsToolStripMenuItem.Name = "retrieveProjectsToolStripMenuItem";
            this.retrieveProjectsToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.retrieveProjectsToolStripMenuItem.Text = "Retrieve Projects";
            this.retrieveProjectsToolStripMenuItem.Click += new System.EventHandler(this.retrieveProjectsToolStripMenuItem_Click);
            // 
            // getProjectByNameToolStripMenuItem
            // 
            this.getProjectByNameToolStripMenuItem.Name = "getProjectByNameToolStripMenuItem";
            this.getProjectByNameToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.getProjectByNameToolStripMenuItem.Text = "Get Project by name";
            this.getProjectByNameToolStripMenuItem.Click += new System.EventHandler(this.getProjectByNameToolStripMenuItem_Click);
            // 
            // getALLProjectsToolStripMenuItem
            // 
            this.getALLProjectsToolStripMenuItem.Name = "getALLProjectsToolStripMenuItem";
            this.getALLProjectsToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.getALLProjectsToolStripMenuItem.Text = "Get ALL projects";
            this.getALLProjectsToolStripMenuItem.Click += new System.EventHandler(this.getALLProjectsToolStripMenuItem_Click);
            // 
            // updateProjectToolStripMenuItem
            // 
            this.updateProjectToolStripMenuItem.Name = "updateProjectToolStripMenuItem";
            this.updateProjectToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.updateProjectToolStripMenuItem.Text = "Update Project";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDepartmentByToolStripMenuItem,
            this.getALLDepartmentsToolStripMenuItem,
            this.addDepartmentToolStripMenuItem,
            this.updateDepartmentToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // getDepartmentByToolStripMenuItem
            // 
            this.getDepartmentByToolStripMenuItem.Name = "getDepartmentByToolStripMenuItem";
            this.getDepartmentByToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.getDepartmentByToolStripMenuItem.Text = "Get Department by name";
            this.getDepartmentByToolStripMenuItem.Click += new System.EventHandler(this.getDepartmentByToolStripMenuItem_Click);
            // 
            // getALLDepartmentsToolStripMenuItem
            // 
            this.getALLDepartmentsToolStripMenuItem.Name = "getALLDepartmentsToolStripMenuItem";
            this.getALLDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.getALLDepartmentsToolStripMenuItem.Text = "Get ALL Departments";
            this.getALLDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.getALLDepartmentsToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // updateDepartmentToolStripMenuItem
            // 
            this.updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            this.updateDepartmentToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.updateDepartmentToolStripMenuItem.Text = "Update Department";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(86, 281);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(233, 35);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // salarySearchBtn
            // 
            this.salarySearchBtn.Location = new System.Drawing.Point(86, 117);
            this.salarySearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salarySearchBtn.Name = "salarySearchBtn";
            this.salarySearchBtn.Size = new System.Drawing.Size(233, 35);
            this.salarySearchBtn.TabIndex = 5;
            this.salarySearchBtn.Text = "Salary Search";
            this.salarySearchBtn.UseVisualStyleBackColor = true;
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(86, 162);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(233, 35);
            this.statisticsBtn.TabIndex = 6;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // SalarySearch
            // 
            this.SalarySearch.Location = new System.Drawing.Point(86, 169);
            this.SalarySearch.Name = "SalarySearch";
            this.SalarySearch.Size = new System.Drawing.Size(233, 35);
            this.SalarySearch.TabIndex = 7;
            this.SalarySearch.Text = "Salary Search";
            this.SalarySearch.UseVisualStyleBackColor = true;
            this.SalarySearch.Click += new System.EventHandler(this.SalarySearch_Click);
            // 
            // Provided_Functionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 334);
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.salarySearchBtn);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.viewEmployeesButton);
            this.Controls.Add(this.providedFunctionalitiesMenuStrip);
            this.MainMenuStrip = this.providedFunctionalitiesMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Provided_Functionalities";
            this.Text = "Provided_Functionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Provided_Functionalities_FormClosed);
            this.Load += new System.EventHandler(this.Provided_Functionalities_Load);
            this.providedFunctionalitiesMenuStrip.ResumeLayout(false);
            this.providedFunctionalitiesMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button viewEmployeesButton;
        private System.Windows.Forms.MenuStrip providedFunctionalitiesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDepartmentByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProjectByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getALLProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getALLDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private System.Windows.Forms.Button salarySearchBtn;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Button SalarySearch;
    }
}