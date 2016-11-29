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
            this.SetEmailBoxx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditUserBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulingDatabaseDataSet1 = new ScheduleGenerator.SchedulingDatabaseDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitChangesButton = new System.Windows.Forms.Button();
            this.SetPasswordBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new ScheduleGenerator.SchedulingDatabaseDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // SetFirstNameTextBox
            // 
            this.SetFirstNameTextBox.Location = new System.Drawing.Point(99, 54);
            this.SetFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetFirstNameTextBox.Name = "SetFirstNameTextBox";
            this.SetFirstNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.SetFirstNameTextBox.TabIndex = 2;
            // 
            // SetLastNameTextBox
            // 
            this.SetLastNameTextBox.Location = new System.Drawing.Point(99, 84);
            this.SetLastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetLastNameTextBox.Name = "SetLastNameTextBox";
            this.SetLastNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.SetLastNameTextBox.TabIndex = 3;
            // 
            // SetEmailBoxx
            // 
            this.SetEmailBoxx.Location = new System.Drawing.Point(99, 112);
            this.SetEmailBoxx.Margin = new System.Windows.Forms.Padding(2);
            this.SetEmailBoxx.Name = "SetEmailBoxx";
            this.SetEmailBoxx.Size = new System.Drawing.Size(76, 20);
            this.SetEmailBoxx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // EditUserBox
            // 
            this.EditUserBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeBindingSource, "EmployeeID", true));
            this.EditUserBox.FormattingEnabled = true;
            this.EditUserBox.Location = new System.Drawing.Point(99, 9);
            this.EditUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditUserBox.Name = "EditUserBox";
            this.EditUserBox.Size = new System.Drawing.Size(76, 21);
            this.EditUserBox.TabIndex = 0;
            this.EditUserBox.SelectedIndexChanged += new System.EventHandler(this.EditUserBox_SelectedIndexChanged);
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
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Employee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // SubmitChangesButton
            // 
            this.SubmitChangesButton.Location = new System.Drawing.Point(191, 132);
            this.SubmitChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitChangesButton.Name = "SubmitChangesButton";
            this.SubmitChangesButton.Size = new System.Drawing.Size(78, 39);
            this.SubmitChangesButton.TabIndex = 6;
            this.SubmitChangesButton.Text = "Submit";
            this.SubmitChangesButton.UseVisualStyleBackColor = true;
            this.SubmitChangesButton.Click += new System.EventHandler(this.SubmitChangesButton_Click);
            // 
            // SetPasswordBox
            // 
            this.SetPasswordBox.Location = new System.Drawing.Point(99, 142);
            this.SetPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetPasswordBox.Name = "SetPasswordBox";
            this.SetPasswordBox.Size = new System.Drawing.Size(76, 20);
            this.SetPasswordBox.TabIndex = 5;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubmitChangesButton);
            this.Controls.Add(this.SetPasswordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditUserBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetEmailBoxx);
            this.Controls.Add(this.SetLastNameTextBox);
            this.Controls.Add(this.SetFirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditUserForm";
            this.Text = "Edit Employee Form";
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
        private System.Windows.Forms.TextBox SetEmailBoxx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EditUserBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitChangesButton;
        private System.Windows.Forms.TextBox SetPasswordBox;
        private SchedulingDatabaseDataSet1 schedulingDatabaseDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private SchedulingDatabaseDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}