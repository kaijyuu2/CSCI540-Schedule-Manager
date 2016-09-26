namespace WindowsFormsApplication1
{
    partial class AdminScheduleForm
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
            this.GeneratedScheduleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SubmitFinalScheduleButton = new System.Windows.Forms.Button();
            this.BuisinessHoursButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewFinalScheduleButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Employee2AvailabilityGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Employee2AvailabilityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratedScheduleLabel
            // 
            this.GeneratedScheduleLabel.AutoSize = true;
            this.GeneratedScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedScheduleLabel.Location = new System.Drawing.Point(248, 9);
            this.GeneratedScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneratedScheduleLabel.Name = "GeneratedScheduleLabel";
            this.GeneratedScheduleLabel.Size = new System.Drawing.Size(281, 25);
            this.GeneratedScheduleLabel.TabIndex = 14;
            this.GeneratedScheduleLabel.Text = "Generated Schedule (Editable)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Employee Schedules";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubmitFinalScheduleButton
            // 
            this.SubmitFinalScheduleButton.Location = new System.Drawing.Point(426, 611);
            this.SubmitFinalScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitFinalScheduleButton.Name = "SubmitFinalScheduleButton";
            this.SubmitFinalScheduleButton.Size = new System.Drawing.Size(235, 33);
            this.SubmitFinalScheduleButton.TabIndex = 16;
            this.SubmitFinalScheduleButton.Text = "Submit Final Schedule";
            this.SubmitFinalScheduleButton.UseVisualStyleBackColor = true;
            // 
            // BuisinessHoursButton
            // 
            this.BuisinessHoursButton.Location = new System.Drawing.Point(146, 608);
            this.BuisinessHoursButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuisinessHoursButton.Name = "BuisinessHoursButton";
            this.BuisinessHoursButton.Size = new System.Drawing.Size(201, 33);
            this.BuisinessHoursButton.TabIndex = 17;
            this.BuisinessHoursButton.Text = "Enter Your Buisiness Hours";
            this.BuisinessHoursButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 36);
            this.button2.TabIndex = 51;
            this.button2.Text = "Generate Editable Schedule";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewFinalScheduleButton
            // 
            this.ViewFinalScheduleButton.Location = new System.Drawing.Point(426, 565);
            this.ViewFinalScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewFinalScheduleButton.Name = "ViewFinalScheduleButton";
            this.ViewFinalScheduleButton.Size = new System.Drawing.Size(235, 38);
            this.ViewFinalScheduleButton.TabIndex = 52;
            this.ViewFinalScheduleButton.Text = "View Final Schedule";
            this.ViewFinalScheduleButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 34);
            this.button3.TabIndex = 53;
            this.button3.Text = "Edit Employees";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Employee2AvailabilityGridView
            // 
            this.Employee2AvailabilityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee2AvailabilityGridView.Location = new System.Drawing.Point(3, 37);
            this.Employee2AvailabilityGridView.Name = "Employee2AvailabilityGridView";
            this.Employee2AvailabilityGridView.RowTemplate.Height = 24;
            this.Employee2AvailabilityGridView.Size = new System.Drawing.Size(813, 464);
            this.Employee2AvailabilityGridView.TabIndex = 171;
            // 
            // AdminScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 826);
            this.Controls.Add(this.Employee2AvailabilityGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ViewFinalScheduleButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BuisinessHoursButton);
            this.Controls.Add(this.SubmitFinalScheduleButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GeneratedScheduleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminScheduleForm";
            this.Text = "AdminScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Employee2AvailabilityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GeneratedScheduleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SubmitFinalScheduleButton;
        private System.Windows.Forms.Button BuisinessHoursButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewFinalScheduleButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Employee2AvailabilityGridView;
    }
}