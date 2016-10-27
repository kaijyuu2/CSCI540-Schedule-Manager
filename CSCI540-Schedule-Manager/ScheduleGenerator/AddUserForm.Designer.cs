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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.AddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneratedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddIDTextBox = new System.Windows.Forms.TextBox();
            this.AddEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(259, 73);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(98, 25);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add Employee";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddFirstNameTextBox
            // 
            this.AddFirstNameTextBox.Location = new System.Drawing.Point(78, 10);
            this.AddFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddFirstNameTextBox.Name = "AddFirstNameTextBox";
            this.AddFirstNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddFirstNameTextBox.TabIndex = 3;
            // 
            // AddLastNameTextBox
            // 
            this.AddLastNameTextBox.Location = new System.Drawing.Point(78, 35);
            this.AddLastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddLastNameTextBox.Name = "AddLastNameTextBox";
            this.AddLastNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddLastNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generated Password";
            // 
            // GeneratedPasswordTextBox
            // 
            this.GeneratedPasswordTextBox.Location = new System.Drawing.Point(316, 10);
            this.GeneratedPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneratedPasswordTextBox.Name = "GeneratedPasswordTextBox";
            this.GeneratedPasswordTextBox.Size = new System.Drawing.Size(76, 20);
            this.GeneratedPasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Id";
            // 
            // AddIDTextBox
            // 
            this.AddIDTextBox.Location = new System.Drawing.Point(78, 58);
            this.AddIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddIDTextBox.Name = "AddIDTextBox";
            this.AddIDTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddIDTextBox.TabIndex = 8;
            // 
            // AddEmailTextBox
            // 
            this.AddEmailTextBox.Location = new System.Drawing.Point(78, 80);
            this.AddEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEmailTextBox.Name = "AddEmailTextBox";
            this.AddEmailTextBox.Size = new System.Drawing.Size(116, 20);
            this.AddEmailTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 114);
            this.Controls.Add(this.AddEmailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GeneratedPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddLastNameTextBox);
            this.Controls.Add(this.AddFirstNameTextBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
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
        private System.Windows.Forms.TextBox GeneratedPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddIDTextBox;
        private System.Windows.Forms.TextBox AddEmailTextBox;
        private System.Windows.Forms.Label label5;
    }
}