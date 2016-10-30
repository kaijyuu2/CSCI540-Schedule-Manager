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
            this.askOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewScheduleTab = new System.Windows.Forms.TabPage();
            this.AvailabilityTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailabilityButton = new System.Windows.Forms.Button();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.toSaturdayTextBox = new System.Windows.Forms.TextBox();
            this.toFridayTextBox = new System.Windows.Forms.TextBox();
            this.toThursdayTextBox = new System.Windows.Forms.TextBox();
            this.toWednesdayTextBox = new System.Windows.Forms.TextBox();
            this.toTuesdayTextBox = new System.Windows.Forms.TextBox();
            this.toMondayTextBox = new System.Windows.Forms.TextBox();
            this.toSundayTextBox = new System.Windows.Forms.TextBox();
            this.fromSaturdayTextBox = new System.Windows.Forms.TextBox();
            this.fromFridayTextBox = new System.Windows.Forms.TextBox();
            this.fromThursdayTextBox = new System.Windows.Forms.TextBox();
            this.fromWednesdayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromSundayTextBox = new System.Windows.Forms.TextBox();
            this.fromMondayTextBox = new System.Windows.Forms.TextBox();
            this.fromTuesdayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.toSaturdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toFridayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toThursdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toWednesdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toTuesdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toMondayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.toSundayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromSaturdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromFridayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromThursdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromWednesdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fromSundayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromMondayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.fromTuesdayUserViewTextbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.UserMenuStrip.SuspendLayout();
            this.ViewScheduleTab.SuspendLayout();
            this.AvailabilityTab.SuspendLayout();
            this.AvailabilityTable.SuspendLayout();
            this.UserTabControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
<<<<<<< HEAD
            this.ViewScheduleTab.Controls.Add(this.UserScheduleTable);
            this.ViewScheduleTab.Location = new System.Drawing.Point(4, 23);
            this.ViewScheduleTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.ViewScheduleTab.Controls.Add(this.tableLayoutPanel1);
            this.ViewScheduleTab.Location = new System.Drawing.Point(4, 25);
            this.ViewScheduleTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> origin/master
            this.ViewScheduleTab.Name = "ViewScheduleTab";
            this.ViewScheduleTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewScheduleTab.Size = new System.Drawing.Size(560, 387);
            this.ViewScheduleTab.TabIndex = 2;
            this.ViewScheduleTab.Text = "View Schedule";
            this.ViewScheduleTab.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
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
            this.UserScheduleTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
=======
>>>>>>> origin/master
            // AvailabilityTab
            // 
            this.AvailabilityTab.Controls.Add(this.label8);
            this.AvailabilityTab.Controls.Add(this.AvailabilityButton);
            this.AvailabilityTab.Controls.Add(this.AvailabilityTable);
            this.AvailabilityTab.Location = new System.Drawing.Point(4, 23);
            this.AvailabilityTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvailabilityTab.Name = "AvailabilityTab";
            this.AvailabilityTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvailabilityTab.Size = new System.Drawing.Size(560, 387);
            this.AvailabilityTab.TabIndex = 0;
            this.AvailabilityTab.Text = "Availability";
            this.AvailabilityTab.UseVisualStyleBackColor = true;
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
            // AvailabilityButton
            // 
            this.AvailabilityButton.Location = new System.Drawing.Point(244, 188);
            this.AvailabilityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AvailabilityTable.Controls.Add(this.toSaturdayTextBox, 7, 2);
            this.AvailabilityTable.Controls.Add(this.toFridayTextBox, 6, 2);
            this.AvailabilityTable.Controls.Add(this.toThursdayTextBox, 5, 2);
            this.AvailabilityTable.Controls.Add(this.toWednesdayTextBox, 4, 2);
            this.AvailabilityTable.Controls.Add(this.toTuesdayTextBox, 3, 2);
            this.AvailabilityTable.Controls.Add(this.toMondayTextBox, 2, 2);
            this.AvailabilityTable.Controls.Add(this.toSundayTextBox, 1, 2);
            this.AvailabilityTable.Controls.Add(this.fromSaturdayTextBox, 7, 1);
            this.AvailabilityTable.Controls.Add(this.fromFridayTextBox, 6, 1);
            this.AvailabilityTable.Controls.Add(this.fromThursdayTextBox, 5, 1);
            this.AvailabilityTable.Controls.Add(this.fromWednesdayTextBox, 4, 1);
            this.AvailabilityTable.Controls.Add(this.label1, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label2, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label3, 3, 0);
            this.AvailabilityTable.Controls.Add(this.label4, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 6, 0);
            this.AvailabilityTable.Controls.Add(this.label7, 7, 0);
            this.AvailabilityTable.Controls.Add(this.fromSundayTextBox, 1, 1);
            this.AvailabilityTable.Controls.Add(this.fromMondayTextBox, 2, 1);
            this.AvailabilityTable.Controls.Add(this.fromTuesdayTextBox, 3, 1);
            this.AvailabilityTable.Controls.Add(this.label9, 0, 1);
            this.AvailabilityTable.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityTable.Location = new System.Drawing.Point(4, 5);
            this.AvailabilityTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 3;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.AvailabilityTable.Size = new System.Drawing.Size(554, 153);
            this.AvailabilityTable.TabIndex = 0;
            this.AvailabilityTable.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailabilityTable_Paint);
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
            // toSaturdayTextBox
            // 
<<<<<<< HEAD
            this.toSaturdayTextBox.Location = new System.Drawing.Point(484, 114);
=======
            this.toSaturdayTextBox.Location = new System.Drawing.Point(647, 141);
            this.toSaturdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toSaturdayTextBox.Name = "toSaturdayTextBox";
            this.toSaturdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.toSaturdayTextBox.TabIndex = 23;
            // 
            // toFridayTextBox
            // 
<<<<<<< HEAD
            this.toFridayTextBox.Location = new System.Drawing.Point(421, 114);
=======
            this.toFridayTextBox.Location = new System.Drawing.Point(562, 141);
            this.toFridayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toFridayTextBox.Name = "toFridayTextBox";
            this.toFridayTextBox.Size = new System.Drawing.Size(54, 19);
            this.toFridayTextBox.TabIndex = 22;
            // 
            // toThursdayTextBox
            // 
<<<<<<< HEAD
            this.toThursdayTextBox.Location = new System.Drawing.Point(355, 114);
=======
            this.toThursdayTextBox.Location = new System.Drawing.Point(474, 141);
            this.toThursdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toThursdayTextBox.Name = "toThursdayTextBox";
            this.toThursdayTextBox.Size = new System.Drawing.Size(57, 19);
            this.toThursdayTextBox.TabIndex = 21;
            // 
            // toWednesdayTextBox
            // 
<<<<<<< HEAD
            this.toWednesdayTextBox.Location = new System.Drawing.Point(277, 114);
=======
            this.toWednesdayTextBox.Location = new System.Drawing.Point(370, 141);
            this.toWednesdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toWednesdayTextBox.Name = "toWednesdayTextBox";
            this.toWednesdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.toWednesdayTextBox.TabIndex = 20;
            // 
            // toTuesdayTextBox
            // 
<<<<<<< HEAD
            this.toTuesdayTextBox.Location = new System.Drawing.Point(207, 114);
=======
            this.toTuesdayTextBox.Location = new System.Drawing.Point(276, 141);
            this.toTuesdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toTuesdayTextBox.Name = "toTuesdayTextBox";
            this.toTuesdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.toTuesdayTextBox.TabIndex = 19;
            // 
            // toMondayTextBox
            // 
<<<<<<< HEAD
            this.toMondayTextBox.Location = new System.Drawing.Point(137, 114);
=======
            this.toMondayTextBox.Location = new System.Drawing.Point(182, 141);
            this.toMondayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toMondayTextBox.Name = "toMondayTextBox";
            this.toMondayTextBox.Size = new System.Drawing.Size(60, 19);
            this.toMondayTextBox.TabIndex = 18;
            // 
            // toSundayTextBox
            // 
<<<<<<< HEAD
            this.toSundayTextBox.Location = new System.Drawing.Point(68, 114);
=======
            this.toSundayTextBox.Location = new System.Drawing.Point(89, 141);
            this.toSundayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.toSundayTextBox.Name = "toSundayTextBox";
            this.toSundayTextBox.Size = new System.Drawing.Size(60, 19);
            this.toSundayTextBox.TabIndex = 17;
            // 
            // fromSaturdayTextBox
            // 
<<<<<<< HEAD
            this.fromSaturdayTextBox.Location = new System.Drawing.Point(484, 73);
=======
            this.fromSaturdayTextBox.Location = new System.Drawing.Point(647, 89);
            this.fromSaturdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromSaturdayTextBox.Name = "fromSaturdayTextBox";
            this.fromSaturdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.fromSaturdayTextBox.TabIndex = 15;
            // 
            // fromFridayTextBox
            // 
<<<<<<< HEAD
            this.fromFridayTextBox.Location = new System.Drawing.Point(421, 73);
=======
            this.fromFridayTextBox.Location = new System.Drawing.Point(562, 89);
            this.fromFridayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromFridayTextBox.Name = "fromFridayTextBox";
            this.fromFridayTextBox.Size = new System.Drawing.Size(54, 19);
            this.fromFridayTextBox.TabIndex = 14;
            // 
            // fromThursdayTextBox
            // 
<<<<<<< HEAD
            this.fromThursdayTextBox.Location = new System.Drawing.Point(355, 73);
=======
            this.fromThursdayTextBox.Location = new System.Drawing.Point(474, 89);
            this.fromThursdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromThursdayTextBox.Name = "fromThursdayTextBox";
            this.fromThursdayTextBox.Size = new System.Drawing.Size(57, 19);
            this.fromThursdayTextBox.TabIndex = 13;
            // 
            // fromWednesdayTextBox
            // 
<<<<<<< HEAD
            this.fromWednesdayTextBox.Location = new System.Drawing.Point(277, 73);
=======
            this.fromWednesdayTextBox.Location = new System.Drawing.Point(370, 89);
            this.fromWednesdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromWednesdayTextBox.Name = "fromWednesdayTextBox";
            this.fromWednesdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.fromWednesdayTextBox.TabIndex = 12;
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
            // fromSundayTextBox
            // 
<<<<<<< HEAD
            this.fromSundayTextBox.Location = new System.Drawing.Point(68, 73);
=======
            this.fromSundayTextBox.Location = new System.Drawing.Point(89, 89);
            this.fromSundayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromSundayTextBox.Name = "fromSundayTextBox";
            this.fromSundayTextBox.Size = new System.Drawing.Size(60, 19);
            this.fromSundayTextBox.TabIndex = 7;
            // 
            // fromMondayTextBox
            // 
<<<<<<< HEAD
            this.fromMondayTextBox.Location = new System.Drawing.Point(137, 73);
=======
            this.fromMondayTextBox.Location = new System.Drawing.Point(182, 89);
            this.fromMondayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromMondayTextBox.Name = "fromMondayTextBox";
            this.fromMondayTextBox.Size = new System.Drawing.Size(60, 19);
            this.fromMondayTextBox.TabIndex = 8;
            // 
            // fromTuesdayTextBox
            // 
<<<<<<< HEAD
            this.fromTuesdayTextBox.Location = new System.Drawing.Point(207, 73);
=======
            this.fromTuesdayTextBox.Location = new System.Drawing.Point(276, 89);
            this.fromTuesdayTextBox.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> origin/master
            this.fromTuesdayTextBox.Name = "fromTuesdayTextBox";
            this.fromTuesdayTextBox.Size = new System.Drawing.Size(60, 19);
            this.fromTuesdayTextBox.TabIndex = 9;
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
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.AvailabilityTab);
            this.UserTabControl.Controls.Add(this.ViewScheduleTab);
            this.UserTabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.UserTabControl.Location = new System.Drawing.Point(9, 25);
            this.UserTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(568, 414);
            this.UserTabControl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.95092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30772F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toSaturdayUserViewTextbox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.toFridayUserViewTextbox, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.toThursdayUserViewTextbox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.toWednesdayUserViewTextbox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.toTuesdayUserViewTextbox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.toMondayUserViewTextbox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.toSundayUserViewTextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fromSaturdayUserViewTextbox, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromFridayUserViewTextbox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromThursdayUserViewTextbox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromWednesdayUserViewTextbox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label18, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.fromSundayUserViewTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromMondayUserViewTextbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromTuesdayUserViewTextbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 188);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "To:";
            // 
            // toSaturdayUserViewTextbox
            // 
            this.toSaturdayUserViewTextbox.Location = new System.Drawing.Point(647, 141);
            this.toSaturdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toSaturdayUserViewTextbox.Name = "toSaturdayUserViewTextbox";
            this.toSaturdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.toSaturdayUserViewTextbox.TabIndex = 23;
            // 
            // toFridayUserViewTextbox
            // 
            this.toFridayUserViewTextbox.Location = new System.Drawing.Point(562, 141);
            this.toFridayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toFridayUserViewTextbox.Name = "toFridayUserViewTextbox";
            this.toFridayUserViewTextbox.Size = new System.Drawing.Size(71, 22);
            this.toFridayUserViewTextbox.TabIndex = 22;
            // 
            // toThursdayUserViewTextbox
            // 
            this.toThursdayUserViewTextbox.Location = new System.Drawing.Point(474, 141);
            this.toThursdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toThursdayUserViewTextbox.Name = "toThursdayUserViewTextbox";
            this.toThursdayUserViewTextbox.Size = new System.Drawing.Size(75, 22);
            this.toThursdayUserViewTextbox.TabIndex = 21;
            // 
            // toWednesdayUserViewTextbox
            // 
            this.toWednesdayUserViewTextbox.Location = new System.Drawing.Point(370, 141);
            this.toWednesdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toWednesdayUserViewTextbox.Name = "toWednesdayUserViewTextbox";
            this.toWednesdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.toWednesdayUserViewTextbox.TabIndex = 20;
            // 
            // toTuesdayUserViewTextbox
            // 
            this.toTuesdayUserViewTextbox.Location = new System.Drawing.Point(276, 141);
            this.toTuesdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toTuesdayUserViewTextbox.Name = "toTuesdayUserViewTextbox";
            this.toTuesdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.toTuesdayUserViewTextbox.TabIndex = 19;
            // 
            // toMondayUserViewTextbox
            // 
            this.toMondayUserViewTextbox.Location = new System.Drawing.Point(182, 141);
            this.toMondayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toMondayUserViewTextbox.Name = "toMondayUserViewTextbox";
            this.toMondayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.toMondayUserViewTextbox.TabIndex = 18;
            // 
            // toSundayUserViewTextbox
            // 
            this.toSundayUserViewTextbox.Location = new System.Drawing.Point(89, 141);
            this.toSundayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toSundayUserViewTextbox.Name = "toSundayUserViewTextbox";
            this.toSundayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.toSundayUserViewTextbox.TabIndex = 17;
            // 
            // fromSaturdayUserViewTextbox
            // 
            this.fromSaturdayUserViewTextbox.Location = new System.Drawing.Point(647, 89);
            this.fromSaturdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromSaturdayUserViewTextbox.Name = "fromSaturdayUserViewTextbox";
            this.fromSaturdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.fromSaturdayUserViewTextbox.TabIndex = 15;
            // 
            // fromFridayUserViewTextbox
            // 
            this.fromFridayUserViewTextbox.Location = new System.Drawing.Point(562, 89);
            this.fromFridayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromFridayUserViewTextbox.Name = "fromFridayUserViewTextbox";
            this.fromFridayUserViewTextbox.Size = new System.Drawing.Size(71, 22);
            this.fromFridayUserViewTextbox.TabIndex = 14;
            // 
            // fromThursdayUserViewTextbox
            // 
            this.fromThursdayUserViewTextbox.Location = new System.Drawing.Point(474, 89);
            this.fromThursdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromThursdayUserViewTextbox.Name = "fromThursdayUserViewTextbox";
            this.fromThursdayUserViewTextbox.Size = new System.Drawing.Size(75, 22);
            this.fromThursdayUserViewTextbox.TabIndex = 13;
            // 
            // fromWednesdayUserViewTextbox
            // 
            this.fromWednesdayUserViewTextbox.Location = new System.Drawing.Point(370, 89);
            this.fromWednesdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromWednesdayUserViewTextbox.Name = "fromWednesdayUserViewTextbox";
            this.fromWednesdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.fromWednesdayUserViewTextbox.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sunday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Monday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tuesday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Wednesday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(473, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Thursday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(561, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Friday";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(646, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Saturday";
            // 
            // fromSundayUserViewTextbox
            // 
            this.fromSundayUserViewTextbox.Location = new System.Drawing.Point(89, 89);
            this.fromSundayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromSundayUserViewTextbox.Name = "fromSundayUserViewTextbox";
            this.fromSundayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.fromSundayUserViewTextbox.TabIndex = 7;
            // 
            // fromMondayUserViewTextbox
            // 
            this.fromMondayUserViewTextbox.Location = new System.Drawing.Point(182, 89);
            this.fromMondayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromMondayUserViewTextbox.Name = "fromMondayUserViewTextbox";
            this.fromMondayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.fromMondayUserViewTextbox.TabIndex = 8;
            // 
            // fromTuesdayUserViewTextbox
            // 
            this.fromTuesdayUserViewTextbox.Location = new System.Drawing.Point(276, 89);
            this.fromTuesdayUserViewTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fromTuesdayUserViewTextbox.Name = "fromTuesdayUserViewTextbox";
            this.fromTuesdayUserViewTextbox.Size = new System.Drawing.Size(79, 22);
            this.fromTuesdayUserViewTextbox.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "From:";
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
            this.Text = "User Form";
            this.UserMenuStrip.ResumeLayout(false);
            this.UserMenuStrip.PerformLayout();
            this.ViewScheduleTab.ResumeLayout(false);
            this.AvailabilityTab.ResumeLayout(false);
            this.AvailabilityTab.PerformLayout();
            this.AvailabilityTable.ResumeLayout(false);
            this.AvailabilityTable.PerformLayout();
            this.UserTabControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.MenuStrip UserMenuStrip;
        private System.Windows.Forms.TabPage ViewScheduleTab;
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
        private System.Windows.Forms.TextBox fromSundayTextBox;
        private System.Windows.Forms.TextBox fromMondayTextBox;
        private System.Windows.Forms.TextBox fromTuesdayTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox toSaturdayTextBox;
        private System.Windows.Forms.TextBox toFridayTextBox;
        private System.Windows.Forms.TextBox toThursdayTextBox;
        private System.Windows.Forms.TextBox toWednesdayTextBox;
        private System.Windows.Forms.TextBox toTuesdayTextBox;
        private System.Windows.Forms.TextBox toMondayTextBox;
        private System.Windows.Forms.TextBox toSundayTextBox;
        private System.Windows.Forms.TextBox fromSaturdayTextBox;
        private System.Windows.Forms.TextBox fromFridayTextBox;
        private System.Windows.Forms.TextBox fromThursdayTextBox;
        private System.Windows.Forms.TextBox fromWednesdayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox toSaturdayUserViewTextbox;
        private System.Windows.Forms.TextBox toFridayUserViewTextbox;
        private System.Windows.Forms.TextBox toThursdayUserViewTextbox;
        private System.Windows.Forms.TextBox toWednesdayUserViewTextbox;
        private System.Windows.Forms.TextBox toTuesdayUserViewTextbox;
        private System.Windows.Forms.TextBox toMondayUserViewTextbox;
        private System.Windows.Forms.TextBox toSundayUserViewTextbox;
        private System.Windows.Forms.TextBox fromSaturdayUserViewTextbox;
        private System.Windows.Forms.TextBox fromFridayUserViewTextbox;
        private System.Windows.Forms.TextBox fromThursdayUserViewTextbox;
        private System.Windows.Forms.TextBox fromWednesdayUserViewTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox fromSundayUserViewTextbox;
        private System.Windows.Forms.TextBox fromMondayUserViewTextbox;
        private System.Windows.Forms.TextBox fromTuesdayUserViewTextbox;
        private System.Windows.Forms.Label label19;
    }
}