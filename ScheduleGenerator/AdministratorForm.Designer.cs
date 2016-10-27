namespace ScheduleGenerator
{
    partial class AdministratorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateScheduleTab = new System.Windows.Forms.TabPage();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.GenerateTable = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.ToUserForm = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.GenerateScheduleTab.SuspendLayout();
            this.GenerateTable.SuspendLayout();
            this.AdminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(586, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "AdminMenuStrip";
            // 
            // FileMenuStripItem
            // 
            this.FileMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserMenuItem,
            this.editUserToolStripMenuItem,
            this.ExitMenuItem});
            this.FileMenuStripItem.Name = "FileMenuStripItem";
            this.FileMenuStripItem.Size = new System.Drawing.Size(36, 20);
            this.FileMenuStripItem.Text = "File";
            // 
            // AddUserMenuItem
            // 
            this.AddUserMenuItem.Name = "AddUserMenuItem";
            this.AddUserMenuItem.Size = new System.Drawing.Size(117, 22);
            this.AddUserMenuItem.Text = "Add User";
            this.AddUserMenuItem.Click += new System.EventHandler(this.AddUserMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // GenerateScheduleTab
            // 
            this.GenerateScheduleTab.Controls.Add(this.ToUserForm);
            this.GenerateScheduleTab.Controls.Add(this.GenerateButton);
            this.GenerateScheduleTab.Controls.Add(this.GenerateTable);
            this.GenerateScheduleTab.Location = new System.Drawing.Point(4, 23);
            this.GenerateScheduleTab.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateScheduleTab.Name = "GenerateScheduleTab";
            this.GenerateScheduleTab.Padding = new System.Windows.Forms.Padding(2);
            this.GenerateScheduleTab.Size = new System.Drawing.Size(560, 387);
            this.GenerateScheduleTab.TabIndex = 1;
            this.GenerateScheduleTab.Text = "Generate Schedule";
            this.GenerateScheduleTab.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(222, 247);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(88, 19);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // GenerateTable
            // 
            this.GenerateTable.BackColor = System.Drawing.Color.DarkGray;
            this.GenerateTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.GenerateTable.ColumnCount = 7;
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72223F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37963F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37963F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37963F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37963F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37963F));
            this.GenerateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37962F));
            this.GenerateTable.Controls.Add(this.label7, 6, 0);
            this.GenerateTable.Controls.Add(this.label6, 5, 0);
            this.GenerateTable.Controls.Add(this.label5, 4, 0);
            this.GenerateTable.Controls.Add(this.label3, 2, 0);
            this.GenerateTable.Controls.Add(this.label2, 1, 0);
            this.GenerateTable.Controls.Add(this.label1, 0, 0);
            this.GenerateTable.Controls.Add(this.label4, 3, 0);
            this.GenerateTable.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.GenerateTable.Location = new System.Drawing.Point(2, 5);
            this.GenerateTable.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.RowCount = 2;
            this.GenerateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.GenerateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.GenerateTable.Size = new System.Drawing.Size(554, 210);
            this.GenerateTable.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.GenerateScheduleTab);
            this.AdminTabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.AdminTabControl.Location = new System.Drawing.Point(9, 25);
            this.AdminTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(568, 414);
            this.AdminTabControl.TabIndex = 2;
            // 
            // ToUserForm
            // 
            this.ToUserForm.Location = new System.Drawing.Point(442, 354);
            this.ToUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.ToUserForm.Name = "ToUserForm";
            this.ToUserForm.Size = new System.Drawing.Size(118, 31);
            this.ToUserForm.TabIndex = 3;
            this.ToUserForm.Text = "Go to Employee View";
            this.ToUserForm.UseVisualStyleBackColor = true;
            this.ToUserForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.AdminTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorForm";
            this.Text = "Administrator Name";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.GenerateScheduleTab.ResumeLayout(false);
            this.GenerateTable.ResumeLayout(false);
            this.GenerateTable.PerformLayout();
            this.AdminTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.TabPage GenerateScheduleTab;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel GenerateTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.Button ToUserForm;
    }
}