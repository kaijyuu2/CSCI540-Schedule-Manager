namespace ScheduleGenerator
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SetLastNameTextBox = new System.Windows.Forms.TextBox();
            this.SetPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangeFirstNameButton = new System.Windows.Forms.Button();
            this.ChangeLastNameButton = new System.Windows.Forms.Button();
            this.SetPasswordButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EditUserBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulingDatabaseDataSet1 = new ScheduleGenerator.SchedulingDatabaseDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SetEmailButton = new System.Windows.Forms.Button();
            this.SetEmailTextBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new ScheduleGenerator.SchedulingDatabaseDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // SetFirstNameTextBox
            // 
            this.SetFirstNameTextBox.Location = new System.Drawing.Point(132, 66);
            this.SetFirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetFirstNameTextBox.Name = "SetFirstNameTextBox";
            this.SetFirstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SetFirstNameTextBox.TabIndex = 2;
            // 
            // SetLastNameTextBox
            // 
            this.SetLastNameTextBox.Location = new System.Drawing.Point(132, 103);
            this.SetLastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetLastNameTextBox.Name = "SetLastNameTextBox";
            this.SetLastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SetLastNameTextBox.TabIndex = 3;
            // 
            // SetPasswordTextBox
            // 
            this.SetPasswordTextBox.Location = new System.Drawing.Point(132, 138);
            this.SetPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetPasswordTextBox.Name = "SetPasswordTextBox";
            this.SetPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.SetPasswordTextBox.TabIndex = 4;
            // 
            // ChangeFirstNameButton
            // 
            this.ChangeFirstNameButton.Location = new System.Drawing.Point(255, 66);
            this.ChangeFirstNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeFirstNameButton.Name = "ChangeFirstNameButton";
            this.ChangeFirstNameButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeFirstNameButton.TabIndex = 5;
            this.ChangeFirstNameButton.Text = "Change";
            this.ChangeFirstNameButton.UseVisualStyleBackColor = true;
            this.ChangeFirstNameButton.Click += new System.EventHandler(this.ChangeFirstNameButton_Click);
            // 
            // ChangeLastNameButton
            // 
            this.ChangeLastNameButton.Location = new System.Drawing.Point(255, 103);
            this.ChangeLastNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeLastNameButton.Name = "ChangeLastNameButton";
            this.ChangeLastNameButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeLastNameButton.TabIndex = 6;
            this.ChangeLastNameButton.Text = "Change";
            this.ChangeLastNameButton.UseVisualStyleBackColor = true;
            this.ChangeLastNameButton.Click += new System.EventHandler(this.ChangeLastNameButton_Click);
            // 
            // SetPasswordButton
            // 
            this.SetPasswordButton.Location = new System.Drawing.Point(255, 138);
            this.SetPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetPasswordButton.Name = "SetPasswordButton";
            this.SetPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.SetPasswordButton.TabIndex = 7;
            this.SetPasswordButton.Text = "Change";
            this.SetPasswordButton.UseVisualStyleBackColor = true;
            this.SetPasswordButton.Click += new System.EventHandler(this.SetPasswordButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // EditUserBox
            // 
            this.EditUserBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource, "EmployeeID", true));
            this.EditUserBox.FormattingEnabled = true;
            this.EditUserBox.Location = new System.Drawing.Point(132, 11);
            this.EditUserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditUserBox.Name = "EditUserBox";
            this.EditUserBox.Size = new System.Drawing.Size(100, 24);
            this.EditUserBox.TabIndex = 9;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.schedulingDatabaseDataSet1;
            // 
            // schedulingDatabaseDataSet1
            // 
            this.schedulingDatabaseDataSet1.DataSetName = "SchedulingDatabaseDataSet1";
            this.schedulingDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Employee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectUserButton
            // 
            this.SelectUserButton.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource, "EmployeeID", true));
            this.SelectUserButton.Location = new System.Drawing.Point(255, 11);
            this.SelectUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectUserButton.Name = "SelectUserButton";
            this.SelectUserButton.Size = new System.Drawing.Size(75, 23);
            this.SelectUserButton.TabIndex = 11;
            this.SelectUserButton.Text = "Select";
            this.SelectUserButton.UseVisualStyleBackColor = true;
            this.SelectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // SetEmailButton
            // 
            this.SetEmailButton.Location = new System.Drawing.Point(255, 175);
            this.SetEmailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetEmailButton.Name = "SetEmailButton";
            this.SetEmailButton.Size = new System.Drawing.Size(75, 23);
            this.SetEmailButton.TabIndex = 13;
            this.SetEmailButton.Text = "Change";
            this.SetEmailButton.UseVisualStyleBackColor = true;
            this.SetEmailButton.Click += new System.EventHandler(this.SetEmailButton_Click);
            // 
            // SetEmailTextBox
            // 
            this.SetEmailTextBox.Location = new System.Drawing.Point(132, 175);
            this.SetEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetEmailTextBox.Name = "SetEmailTextBox";
            this.SetEmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.SetEmailTextBox.TabIndex = 12;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 236);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetEmailButton);
            this.Controls.Add(this.SetEmailTextBox);
            this.Controls.Add(this.SelectUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditUserBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetPasswordButton);
            this.Controls.Add(this.ChangeLastNameButton);
            this.Controls.Add(this.ChangeFirstNameButton);
            this.Controls.Add(this.SetPasswordTextBox);
            this.Controls.Add(this.SetLastNameTextBox);
            this.Controls.Add(this.SetFirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditUserForm";
            this.Text = "This will be the admin\'s name";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetFirstNameTextBox;
        private System.Windows.Forms.TextBox SetLastNameTextBox;
        private System.Windows.Forms.TextBox SetPasswordTextBox;
        private System.Windows.Forms.Button ChangeFirstNameButton;
        private System.Windows.Forms.Button ChangeLastNameButton;
        private System.Windows.Forms.Button SetPasswordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EditUserBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SetEmailButton;
        private System.Windows.Forms.TextBox SetEmailTextBox;
        private SchedulingDatabaseDataSet1 schedulingDatabaseDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private SchedulingDatabaseDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}