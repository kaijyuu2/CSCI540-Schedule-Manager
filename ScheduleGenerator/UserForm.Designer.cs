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
            this.UserScheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.UserMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.UserMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.UserMenuStrip.Size = new System.Drawing.Size(781, 24);
            this.UserMenuStrip.TabIndex = 0;
            this.UserMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuStripItem
            // 
            this.FileMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.askOffToolStripMenuItem,
            this.ExitMenuItem});
            this.FileMenuStripItem.Name = "FileMenuStripItem";
            this.FileMenuStripItem.Size = new System.Drawing.Size(40, 20);
            this.FileMenuStripItem.Text = "File";
            // 
            // askOffToolStripMenuItem
            // 
            this.askOffToolStripMenuItem.Name = "askOffToolStripMenuItem";
            this.askOffToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.askOffToolStripMenuItem.Text = "Ask Off";
            this.askOffToolStripMenuItem.Click += new System.EventHandler(this.askOffToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(128, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewScheduleTab
            // 
            this.ViewScheduleTab.Controls.Add(this.UserScheduleTable);
            this.ViewScheduleTab.Location = new System.Drawing.Point(4, 25);
            this.ViewScheduleTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewScheduleTab.Name = "ViewScheduleTab";
            this.ViewScheduleTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewScheduleTab.Size = new System.Drawing.Size(749, 481);
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
            this.UserScheduleTable.Location = new System.Drawing.Point(5, 6);
            this.UserScheduleTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserScheduleTable.Name = "UserScheduleTable";
            this.UserScheduleTable.RowCount = 2;
            this.UserScheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053F));
            this.UserScheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947F));
            this.UserScheduleTable.Size = new System.Drawing.Size(739, 258);
            this.UserScheduleTable.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(635, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Saturday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(530, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Friday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(425, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Thursday";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(215, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tuesday";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(110, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Monday";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Sunday";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(320, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Wednesday";
            // 
            // AvailabilityTab
            // 
            this.AvailabilityTab.Controls.Add(this.label8);
            this.AvailabilityTab.Controls.Add(this.AvailabilityButton);
            this.AvailabilityTab.Controls.Add(this.AvailabilityTable);
            this.AvailabilityTab.Location = new System.Drawing.Point(4, 25);
            this.AvailabilityTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailabilityTab.Name = "AvailabilityTab";
            this.AvailabilityTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailabilityTab.Size = new System.Drawing.Size(749, 481);
            this.AvailabilityTab.TabIndex = 0;
            this.AvailabilityTab.Text = "Availability";
            this.AvailabilityTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Please use 24 hour format";
            // 
            // AvailabilityButton
            // 
            this.AvailabilityButton.Location = new System.Drawing.Point(325, 231);
            this.AvailabilityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailabilityButton.Name = "AvailabilityButton";
            this.AvailabilityButton.Size = new System.Drawing.Size(96, 23);
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
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
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
            this.AvailabilityTable.Location = new System.Drawing.Point(5, 6);
            this.AvailabilityTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 3;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.AvailabilityTable.Size = new System.Drawing.Size(739, 188);
            this.AvailabilityTable.TabIndex = 0;
            this.AvailabilityTable.Paint += new System.Windows.Forms.PaintEventHandler(this.AvailabilityTable_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "To:";
            // 
            // toSaturdayTextBox
            // 
            this.toSaturdayTextBox.Location = new System.Drawing.Point(647, 141);
            this.toSaturdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toSaturdayTextBox.Name = "toSaturdayTextBox";
            this.toSaturdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.toSaturdayTextBox.TabIndex = 23;
            // 
            // toFridayTextBox
            // 
            this.toFridayTextBox.Location = new System.Drawing.Point(562, 141);
            this.toFridayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toFridayTextBox.Name = "toFridayTextBox";
            this.toFridayTextBox.Size = new System.Drawing.Size(71, 22);
            this.toFridayTextBox.TabIndex = 22;
            // 
            // toThursdayTextBox
            // 
            this.toThursdayTextBox.Location = new System.Drawing.Point(474, 141);
            this.toThursdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toThursdayTextBox.Name = "toThursdayTextBox";
            this.toThursdayTextBox.Size = new System.Drawing.Size(75, 22);
            this.toThursdayTextBox.TabIndex = 21;
            // 
            // toWednesdayTextBox
            // 
            this.toWednesdayTextBox.Location = new System.Drawing.Point(370, 141);
            this.toWednesdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toWednesdayTextBox.Name = "toWednesdayTextBox";
            this.toWednesdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.toWednesdayTextBox.TabIndex = 20;
            // 
            // toTuesdayTextBox
            // 
            this.toTuesdayTextBox.Location = new System.Drawing.Point(276, 141);
            this.toTuesdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toTuesdayTextBox.Name = "toTuesdayTextBox";
            this.toTuesdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.toTuesdayTextBox.TabIndex = 19;
            // 
            // toMondayTextBox
            // 
            this.toMondayTextBox.Location = new System.Drawing.Point(182, 141);
            this.toMondayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toMondayTextBox.Name = "toMondayTextBox";
            this.toMondayTextBox.Size = new System.Drawing.Size(79, 22);
            this.toMondayTextBox.TabIndex = 18;
            // 
            // toSundayTextBox
            // 
            this.toSundayTextBox.Location = new System.Drawing.Point(89, 141);
            this.toSundayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toSundayTextBox.Name = "toSundayTextBox";
            this.toSundayTextBox.Size = new System.Drawing.Size(79, 22);
            this.toSundayTextBox.TabIndex = 17;
            // 
            // fromSaturdayTextBox
            // 
            this.fromSaturdayTextBox.Location = new System.Drawing.Point(647, 89);
            this.fromSaturdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromSaturdayTextBox.Name = "fromSaturdayTextBox";
            this.fromSaturdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.fromSaturdayTextBox.TabIndex = 15;
            // 
            // fromFridayTextBox
            // 
            this.fromFridayTextBox.Location = new System.Drawing.Point(562, 89);
            this.fromFridayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromFridayTextBox.Name = "fromFridayTextBox";
            this.fromFridayTextBox.Size = new System.Drawing.Size(71, 22);
            this.fromFridayTextBox.TabIndex = 14;
            // 
            // fromThursdayTextBox
            // 
            this.fromThursdayTextBox.Location = new System.Drawing.Point(474, 89);
            this.fromThursdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromThursdayTextBox.Name = "fromThursdayTextBox";
            this.fromThursdayTextBox.Size = new System.Drawing.Size(75, 22);
            this.fromThursdayTextBox.TabIndex = 13;
            // 
            // fromWednesdayTextBox
            // 
            this.fromWednesdayTextBox.Location = new System.Drawing.Point(370, 89);
            this.fromWednesdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromWednesdayTextBox.Name = "fromWednesdayTextBox";
            this.fromWednesdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.fromWednesdayTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            // 
            // fromSundayTextBox
            // 
            this.fromSundayTextBox.Location = new System.Drawing.Point(89, 89);
            this.fromSundayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromSundayTextBox.Name = "fromSundayTextBox";
            this.fromSundayTextBox.Size = new System.Drawing.Size(79, 22);
            this.fromSundayTextBox.TabIndex = 7;
            // 
            // fromMondayTextBox
            // 
            this.fromMondayTextBox.Location = new System.Drawing.Point(182, 89);
            this.fromMondayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromMondayTextBox.Name = "fromMondayTextBox";
            this.fromMondayTextBox.Size = new System.Drawing.Size(79, 22);
            this.fromMondayTextBox.TabIndex = 8;
            // 
            // fromTuesdayTextBox
            // 
            this.fromTuesdayTextBox.Location = new System.Drawing.Point(276, 89);
            this.fromTuesdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromTuesdayTextBox.Name = "fromTuesdayTextBox";
            this.fromTuesdayTextBox.Size = new System.Drawing.Size(79, 22);
            this.fromTuesdayTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "From:";
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.AvailabilityTab);
            this.UserTabControl.Controls.Add(this.ViewScheduleTab);
            this.UserTabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.UserTabControl.Location = new System.Drawing.Point(12, 31);
            this.UserTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(757, 510);
            this.UserTabControl.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.UserMenuStrip);
            this.MainMenuStrip = this.UserMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}