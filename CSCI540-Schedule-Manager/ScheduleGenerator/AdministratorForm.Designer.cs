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
            this.ViewScheduleTab = new System.Windows.Forms.TabPage();
            this.AdminViewTable = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.menuStrip2.SuspendLayout();
            this.ViewScheduleTab.SuspendLayout();
            this.AdminViewTable.SuspendLayout();
            this.GenerateScheduleTab.SuspendLayout();
            this.GenerateTable.SuspendLayout();
            this.AdminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
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
            this.menuStrip2.Size = new System.Drawing.Size(782, 28);
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
            this.FileMenuStripItem.Size = new System.Drawing.Size(44, 24);
            this.FileMenuStripItem.Text = "File";
            // 
            // AddUserMenuItem
            // 
            this.AddUserMenuItem.Name = "AddUserMenuItem";
            this.AddUserMenuItem.Size = new System.Drawing.Size(145, 26);
            this.AddUserMenuItem.Text = "Add User";
            this.AddUserMenuItem.Click += new System.EventHandler(this.AddUserMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(145, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewScheduleTab
            // 
            this.ViewScheduleTab.Controls.Add(this.AdminViewTable);
            this.ViewScheduleTab.Location = new System.Drawing.Point(4, 25);
            this.ViewScheduleTab.Name = "ViewScheduleTab";
            this.ViewScheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewScheduleTab.Size = new System.Drawing.Size(750, 481);
            this.ViewScheduleTab.TabIndex = 2;
            this.ViewScheduleTab.Text = "View Schedule";
            this.ViewScheduleTab.UseVisualStyleBackColor = true;
            // 
            // AdminViewTable
            // 
            this.AdminViewTable.BackColor = System.Drawing.Color.DarkGray;
            this.AdminViewTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AdminViewTable.ColumnCount = 7;
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15361F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AdminViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30772F));
            this.AdminViewTable.Controls.Add(this.label8, 6, 0);
            this.AdminViewTable.Controls.Add(this.label9, 5, 0);
            this.AdminViewTable.Controls.Add(this.label10, 4, 0);
            this.AdminViewTable.Controls.Add(this.label11, 2, 0);
            this.AdminViewTable.Controls.Add(this.label12, 1, 0);
            this.AdminViewTable.Controls.Add(this.label13, 0, 0);
            this.AdminViewTable.Controls.Add(this.label14, 3, 0);
            this.AdminViewTable.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.AdminViewTable.Location = new System.Drawing.Point(3, 6);
            this.AdminViewTable.Name = "AdminViewTable";
            this.AdminViewTable.RowCount = 2;
            this.AdminViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.AdminViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.AdminViewTable.Size = new System.Drawing.Size(738, 259);
            this.AdminViewTable.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Saturday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Friday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thursday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tuesday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Monday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Sunday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Wednesday";
            // 
            // GenerateScheduleTab
            // 
            this.GenerateScheduleTab.Controls.Add(this.GenerateButton);
            this.GenerateScheduleTab.Controls.Add(this.GenerateTable);
            this.GenerateScheduleTab.Location = new System.Drawing.Point(4, 25);
            this.GenerateScheduleTab.Name = "GenerateScheduleTab";
            this.GenerateScheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.GenerateScheduleTab.Size = new System.Drawing.Size(750, 481);
            this.GenerateScheduleTab.TabIndex = 1;
            this.GenerateScheduleTab.Text = "Generate Schedule";
            this.GenerateScheduleTab.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(296, 304);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(117, 23);
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
            this.GenerateTable.Location = new System.Drawing.Point(3, 6);
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.RowCount = 2;
            this.GenerateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.GenerateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.GenerateTable.Size = new System.Drawing.Size(738, 259);
            this.GenerateTable.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.GenerateScheduleTab);
            this.AdminTabControl.Controls.Add(this.ViewScheduleTab);
            this.AdminTabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.AdminTabControl.Location = new System.Drawing.Point(12, 31);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(758, 510);
            this.AdminTabControl.TabIndex = 2;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.AdminTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorForm";
            this.Text = "Administrator Name";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ViewScheduleTab.ResumeLayout(false);
            this.AdminViewTable.ResumeLayout(false);
            this.AdminViewTable.PerformLayout();
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
        private System.Windows.Forms.TabPage ViewScheduleTab;
        private System.Windows.Forms.TableLayoutPanel AdminViewTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
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
    }
}