namespace ScheduleGenerator
{
    partial class AddUserForm
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
            this.components = new System.ComponentModel.Container();
            this.employeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.admin = new ScheduleGenerator.admin();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstName = new ScheduleGenerator.FirstName();
            this.AddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lastName = new ScheduleGenerator.LastName();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPasswordTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.password = new ScheduleGenerator.Password();
            this.AddEmailTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.email = new ScheduleGenerator.Email();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new ScheduleGenerator.FirstNameTableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter1 = new ScheduleGenerator.LastNameTableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter2 = new ScheduleGenerator.EmailTableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter3 = new ScheduleGenerator.PasswordTableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter4 = new ScheduleGenerator.adminTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource4
            // 
            this.employeeBindingSource4.DataMember = "Employee";
            this.employeeBindingSource4.DataSource = this.admin;
            // 
            // admin
            // 
            this.admin.DataSetName = "admin";
            this.admin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(240, 64);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(98, 25);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add Employee";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddFirstNameTextBox
            // 
            this.AddFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "First name", true));
            this.AddFirstNameTextBox.Location = new System.Drawing.Point(78, 12);
            this.AddFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddFirstNameTextBox.Name = "AddFirstNameTextBox";
            this.AddFirstNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddFirstNameTextBox.TabIndex = 3;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.firstName;
            // 
            // firstName
            // 
            this.firstName.DataSetName = "FirstName";
            this.firstName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddLastNameTextBox
            // 
            this.AddLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Last name", true));
            this.AddLastNameTextBox.Location = new System.Drawing.Point(78, 39);
            this.AddLastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddLastNameTextBox.Name = "AddLastNameTextBox";
            this.AddLastNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddLastNameTextBox.TabIndex = 4;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.lastName;
            // 
            // lastName
            // 
            this.lastName.DataSetName = "LastName";
            this.lastName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(205, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // AddPasswordTextBox
            // 
            this.AddPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource3, "Password", true));
            this.AddPasswordTextBox.Location = new System.Drawing.Point(262, 10);
            this.AddPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddPasswordTextBox.Name = "AddPasswordTextBox";
            this.AddPasswordTextBox.Size = new System.Drawing.Size(76, 20);
            this.AddPasswordTextBox.TabIndex = 6;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.password;
            // 
            // password
            // 
            this.password.DataSetName = "Password";
            this.password.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddEmailTextBox
            // 
            this.AddEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource2, "Email", true));
            this.AddEmailTextBox.Location = new System.Drawing.Point(78, 69);
            this.AddEmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmailTextBox.Name = "AddEmailTextBox";
            this.AddEmailTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddEmailTextBox.TabIndex = 10;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.email;
            // 
            // email
            // 
            this.email.DataSetName = "Email";
            this.email.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeTableAdapter3
            // 
            this.employeeTableAdapter3.ClearBeforeFill = true;
            // 
            // employeeTableAdapter4
            // 
            this.employeeTableAdapter4.ClearBeforeFill = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 120);
            this.Controls.Add(this.AddEmailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddLastNameTextBox);
            this.Controls.Add(this.AddFirstNameTextBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox AddFirstNameTextBox;
        private System.Windows.Forms.TextBox AddLastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddPasswordTextBox;
        private System.Windows.Forms.TextBox AddEmailTextBox;
        private System.Windows.Forms.Label label5;
        private FirstName firstName;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FirstNameTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private LastName lastName;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private LastNameTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private Email email;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private EmailTableAdapters.EmployeeTableAdapter employeeTableAdapter2;
        private Password password;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private PasswordTableAdapters.EmployeeTableAdapter employeeTableAdapter3;
        private admin admin;
        private System.Windows.Forms.BindingSource employeeBindingSource4;
        private adminTableAdapters.EmployeeTableAdapter employeeTableAdapter4;
    }
}