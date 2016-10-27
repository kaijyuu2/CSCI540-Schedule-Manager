namespace ScheduleGenerator
{
    partial class UserForm
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
            this.UserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewScheduleTab = new System.Windows.Forms.TabPage();
            this.UserScheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AvailabilityTab = new System.Windows.Forms.TabPage();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SundayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.MondayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.TuesdayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.WednesdayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.ThursdayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.FridayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.SaturdayAvailabilityBox = new System.Windows.Forms.ComboBox();
            this.AvailabilityButton = new System.Windows.Forms.Button();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.askOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuStrip.SuspendLayout();
            this.ViewScheduleTab.SuspendLayout();
            this.UserScheduleTable.SuspendLayout();
            this.AvailabilityTab.SuspendLayout();
            this.AvailabilityTable.SuspendLayout();
            this.UserTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserMenuStrip
            // 
            this.UserMenuStrip.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.UserMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripItem});
            this.UserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UserMenuStrip.Name = "UserMenuStrip";
            this.UserMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.UserMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.UserMenuStrip.Size = new System.Drawing.Size(586, 24);
            this.UserMenuStrip.TabIndex = 0;
            this.UserMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuStripItem
            // 
            this.FileMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.askOffToolStripMenuItem,
            this.ExitMenuItem});
            this.FileMenuStripItem.Name = "FileMenuStripItem";
            this.FileMenuStripItem.Size = new System.Drawing.Size(36, 20);
            this.FileMenuStripItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewScheduleTab
            // 
            this.ViewScheduleTab.Controls.Add(this.UserScheduleTable);
            this.ViewScheduleTab.Location = new System.Drawing.Point(4, 23);
            this.ViewScheduleTab.Margin = new System.Windows.Forms.Padding(2);
            this.ViewScheduleTab.Name = "ViewScheduleTab";
            this.ViewScheduleTab.Padding = new System.Windows.Forms.Padding(2);
            this.ViewScheduleTab.Size = new System.Drawing.Size(560, 387);
            this.ViewScheduleTab.TabIndex = 2;
            this.ViewScheduleTab.Text = "View Schedule";
            this.ViewScheduleTab.UseVisualStyleBackColor = true;
            // 
            // UserScheduleTable
            // 
            this.UserScheduleTable.BackColor = System.Drawing.Color.DarkGray;
            this.UserScheduleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.UserScheduleTable.ColumnCount = 7;
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15361F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.UserScheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30772F));
            this.UserScheduleTable.Controls.Add(this.label15, 6, 0);
            this.UserScheduleTable.Controls.Add(this.label16, 5, 0);
            this.UserScheduleTable.Controls.Add(this.label17, 4, 0);
            this.UserScheduleTable.Controls.Add(this.label18, 2, 0);
            this.UserScheduleTable.Controls.Add(this.label19, 1, 0);
            this.UserScheduleTable.Controls.Add(this.label20, 0, 0);
            this.UserScheduleTable.Controls.Add(this.label21, 3, 0);
            this.UserScheduleTable.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.UserScheduleTable.Location = new System.Drawing.Point(4, 5);
            this.UserScheduleTable.Margin = new System.Windows.Forms.Padding(2);
            this.UserScheduleTable.Name = "UserScheduleTable";
            this.UserScheduleTable.RowCount = 2;
            this.UserScheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.UserScheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.UserScheduleTable.Size = new System.Drawing.Size(554, 210);
            this.UserScheduleTable.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 3);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Wednesday";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Sunday";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(83, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Monday";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(161, 3);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tuesday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Thursday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Friday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(473, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Saturday";
            // 
            // AvailabilityTab
            // 
            this.AvailabilityTab.Controls.Add(this.AvailabilityButton);
            this.AvailabilityTab.Controls.Add(this.AvailabilityTable);
            this.AvailabilityTab.Location = new System.Drawing.Point(4, 23);
            this.AvailabilityTab.Margin = new System.Windows.Forms.Padding(2);
            this.AvailabilityTab.Name = "AvailabilityTab";
            this.AvailabilityTab.Padding = new System.Windows.Forms.Padding(2);
            this.AvailabilityTab.Size = new System.Drawing.Size(560, 387);
            this.AvailabilityTab.TabIndex = 0;
            this.AvailabilityTab.Text = "Availability";
            this.AvailabilityTab.UseVisualStyleBackColor = true;
            // 
            // AvailabilityTable
            // 
            this.AvailabilityTable.BackColor = System.Drawing.Color.DarkGray;
            this.AvailabilityTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AvailabilityTable.ColumnCount = 7;
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15361F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30772F));
            this.AvailabilityTable.Controls.Add(this.SaturdayAvailabilityBox, 6, 1);
            this.AvailabilityTable.Controls.Add(this.FridayAvailabilityBox, 5, 1);
            this.AvailabilityTable.Controls.Add(this.ThursdayAvailabilityBox, 4, 1);
            this.AvailabilityTable.Controls.Add(this.WednesdayAvailabilityBox, 3, 1);
            this.AvailabilityTable.Controls.Add(this.TuesdayAvailabilityBox, 2, 1);
            this.AvailabilityTable.Controls.Add(this.MondayAvailabilityBox, 1, 1);
            this.AvailabilityTable.Controls.Add(this.SundayAvailabilityBox, 0, 1);
            this.AvailabilityTable.Controls.Add(this.label7, 6, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label3, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label2, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label1, 0, 0);
            this.AvailabilityTable.Controls.Add(this.label4, 3, 0);
            this.AvailabilityTable.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityTable.Location = new System.Drawing.Point(4, 5);
            this.AvailabilityTable.Margin = new System.Windows.Forms.Padding(2);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 2;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.AvailabilityTable.Size = new System.Drawing.Size(554, 178);
            this.AvailabilityTable.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            // 
            // SundayAvailabilityBox
            // 
            this.SundayAvailabilityBox.FormattingEnabled = true;
            this.SundayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.SundayAvailabilityBox.Location = new System.Drawing.Point(5, 65);
            this.SundayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.SundayAvailabilityBox.Name = "SundayAvailabilityBox";
            this.SundayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.SundayAvailabilityBox.TabIndex = 1;
            // 
            // MondayAvailabilityBox
            // 
            this.MondayAvailabilityBox.FormattingEnabled = true;
            this.MondayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.MondayAvailabilityBox.Location = new System.Drawing.Point(83, 65);
            this.MondayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.MondayAvailabilityBox.Name = "MondayAvailabilityBox";
            this.MondayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.MondayAvailabilityBox.TabIndex = 7;
            // 
            // TuesdayAvailabilityBox
            // 
            this.TuesdayAvailabilityBox.FormattingEnabled = true;
            this.TuesdayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.TuesdayAvailabilityBox.Location = new System.Drawing.Point(161, 65);
            this.TuesdayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.TuesdayAvailabilityBox.Name = "TuesdayAvailabilityBox";
            this.TuesdayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.TuesdayAvailabilityBox.TabIndex = 8;
            // 
            // WednesdayAvailabilityBox
            // 
            this.WednesdayAvailabilityBox.FormattingEnabled = true;
            this.WednesdayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.WednesdayAvailabilityBox.Location = new System.Drawing.Point(239, 65);
            this.WednesdayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.WednesdayAvailabilityBox.Name = "WednesdayAvailabilityBox";
            this.WednesdayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.WednesdayAvailabilityBox.TabIndex = 9;
            // 
            // ThursdayAvailabilityBox
            // 
            this.ThursdayAvailabilityBox.FormattingEnabled = true;
            this.ThursdayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.ThursdayAvailabilityBox.Location = new System.Drawing.Point(317, 65);
            this.ThursdayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThursdayAvailabilityBox.Name = "ThursdayAvailabilityBox";
            this.ThursdayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.ThursdayAvailabilityBox.TabIndex = 10;
            // 
            // FridayAvailabilityBox
            // 
            this.FridayAvailabilityBox.FormattingEnabled = true;
            this.FridayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.FridayAvailabilityBox.Location = new System.Drawing.Point(395, 65);
            this.FridayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.FridayAvailabilityBox.Name = "FridayAvailabilityBox";
            this.FridayAvailabilityBox.Size = new System.Drawing.Size(71, 20);
            this.FridayAvailabilityBox.TabIndex = 11;
            // 
            // SaturdayAvailabilityBox
            // 
            this.SaturdayAvailabilityBox.FormattingEnabled = true;
            this.SaturdayAvailabilityBox.Items.AddRange(new object[] {
            "9-5",
            "9-1",
            "1-4",
            "None"});
            this.SaturdayAvailabilityBox.Location = new System.Drawing.Point(473, 65);
            this.SaturdayAvailabilityBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaturdayAvailabilityBox.Name = "SaturdayAvailabilityBox";
            this.SaturdayAvailabilityBox.Size = new System.Drawing.Size(74, 20);
            this.SaturdayAvailabilityBox.TabIndex = 12;
            // 
            // AvailabilityButton
            // 
            this.AvailabilityButton.Location = new System.Drawing.Point(244, 188);
            this.AvailabilityButton.Margin = new System.Windows.Forms.Padding(2);
            this.AvailabilityButton.Name = "AvailabilityButton";
            this.AvailabilityButton.Size = new System.Drawing.Size(72, 19);
            this.AvailabilityButton.TabIndex = 1;
            this.AvailabilityButton.Text = "Submit";
            this.AvailabilityButton.UseVisualStyleBackColor = true;
            this.AvailabilityButton.Click += new System.EventHandler(this.AvailabilityButton_Click);
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.AvailabilityTab);
            this.UserTabControl.Controls.Add(this.ViewScheduleTab);
            this.UserTabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.UserTabControl.Location = new System.Drawing.Point(9, 25);
            this.UserTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(568, 414);
            this.UserTabControl.TabIndex = 1;
            // 
            // askOffToolStripMenuItem
            // 
            this.askOffToolStripMenuItem.Name = "askOffToolStripMenuItem";
            this.askOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.askOffToolStripMenuItem.Text = "Ask Off";
            this.askOffToolStripMenuItem.Click += new System.EventHandler(this.askOffToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.UserMenuStrip);
            this.MainMenuStrip = this.UserMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserForm";
            this.Text = "User Name";
            this.UserMenuStrip.ResumeLayout(false);
            this.UserMenuStrip.PerformLayout();
            this.ViewScheduleTab.ResumeLayout(false);
            this.UserScheduleTable.ResumeLayout(false);
            this.UserScheduleTable.PerformLayout();
            this.AvailabilityTab.ResumeLayout(false);
            this.AvailabilityTable.ResumeLayout(false);
            this.AvailabilityTable.PerformLayout();
            this.UserTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.MenuStrip UserMenuStrip;
        private System.Windows.Forms.TabPage ViewScheduleTab;
        private System.Windows.Forms.TableLayoutPanel UserScheduleTable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage AvailabilityTab;
        private System.Windows.Forms.Button AvailabilityButton;
        private System.Windows.Forms.TableLayoutPanel AvailabilityTable;
        private System.Windows.Forms.ComboBox SaturdayAvailabilityBox;
        private System.Windows.Forms.ComboBox FridayAvailabilityBox;
        private System.Windows.Forms.ComboBox ThursdayAvailabilityBox;
        private System.Windows.Forms.ComboBox WednesdayAvailabilityBox;
        private System.Windows.Forms.ComboBox TuesdayAvailabilityBox;
        private System.Windows.Forms.ComboBox MondayAvailabilityBox;
        private System.Windows.Forms.ComboBox SundayAvailabilityBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.ToolStripMenuItem askOffToolStripMenuItem;
    }
}