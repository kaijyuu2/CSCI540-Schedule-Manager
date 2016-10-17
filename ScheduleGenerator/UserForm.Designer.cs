﻿namespace ScheduleGenerator
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
            this.askOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewScheduleTab = new System.Windows.Forms.TabPage();
            this.UserScheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.AvailabilityTab = new System.Windows.Forms.TabPage();
            this.AvailabilityButton = new System.Windows.Forms.Button();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // askOffToolStripMenuItem
            // 
            this.askOffToolStripMenuItem.Name = "askOffToolStripMenuItem";
            this.askOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.askOffToolStripMenuItem.Text = "Ask Off";
            this.askOffToolStripMenuItem.Click += new System.EventHandler(this.askOffToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(111, 22);
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
            // AvailabilityTab
            // 
            this.AvailabilityTab.Controls.Add(this.label8);
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
            // AvailabilityTable
            // 
            this.AvailabilityTable.BackColor = System.Drawing.Color.DarkGray;
            this.AvailabilityTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AvailabilityTable.ColumnCount = 8;
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15361F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.95092F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49693F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88344F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30772F));
            this.AvailabilityTable.Controls.Add(this.label10, 0, 2);
            this.AvailabilityTable.Controls.Add(this.textBox17, 7, 2);
            this.AvailabilityTable.Controls.Add(this.textBox16, 6, 2);
            this.AvailabilityTable.Controls.Add(this.textBox15, 5, 2);
            this.AvailabilityTable.Controls.Add(this.textBox14, 4, 2);
            this.AvailabilityTable.Controls.Add(this.textBox13, 3, 2);
            this.AvailabilityTable.Controls.Add(this.textBox12, 2, 2);
            this.AvailabilityTable.Controls.Add(this.textBox11, 1, 2);
            this.AvailabilityTable.Controls.Add(this.textBox9, 7, 1);
            this.AvailabilityTable.Controls.Add(this.textBox8, 6, 1);
            this.AvailabilityTable.Controls.Add(this.textBox7, 5, 1);
            this.AvailabilityTable.Controls.Add(this.textBox6, 4, 1);
            this.AvailabilityTable.Controls.Add(this.label1, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label2, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label3, 3, 0);
            this.AvailabilityTable.Controls.Add(this.label4, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 6, 0);
            this.AvailabilityTable.Controls.Add(this.label7, 7, 0);
            this.AvailabilityTable.Controls.Add(this.textBox1, 1, 1);
            this.AvailabilityTable.Controls.Add(this.textBox2, 2, 1);
            this.AvailabilityTable.Controls.Add(this.textBox3, 3, 1);
            this.AvailabilityTable.Controls.Add(this.label9, 0, 1);
            this.AvailabilityTable.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityTable.Location = new System.Drawing.Point(4, 5);
            this.AvailabilityTable.Margin = new System.Windows.Forms.Padding(2);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 3;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.AvailabilityTable.Size = new System.Drawing.Size(554, 153);
            this.AvailabilityTable.TabIndex = 0;
            this.AvailabilityTable.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailabilityTable_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 19);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 19);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 19);
            this.textBox3.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(277, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 19);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(355, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(57, 19);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(421, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 19);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(484, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 19);
            this.textBox9.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(68, 114);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(60, 19);
            this.textBox11.TabIndex = 17;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(137, 114);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(60, 19);
            this.textBox12.TabIndex = 18;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(207, 114);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(60, 19);
            this.textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(277, 114);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(60, 19);
            this.textBox14.TabIndex = 20;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(355, 114);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(57, 19);
            this.textBox15.TabIndex = 21;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(421, 114);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(54, 19);
            this.textBox16.TabIndex = 22;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(484, 114);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(60, 19);
            this.textBox17.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Please use 24 hour format";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.UserMenuStrip);
            this.MainMenuStrip = this.UserMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "User Name";
            this.UserMenuStrip.ResumeLayout(false);
            this.UserMenuStrip.PerformLayout();
            this.ViewScheduleTab.ResumeLayout(false);
            this.UserScheduleTable.ResumeLayout(false);
            this.UserScheduleTable.PerformLayout();
            this.AvailabilityTab.ResumeLayout(false);
            this.AvailabilityTab.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.ToolStripMenuItem askOffToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
    }
}