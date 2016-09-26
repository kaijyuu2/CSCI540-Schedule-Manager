namespace WindowsFormsApplication1
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
            this.SubmitUserScheduleButton = new System.Windows.Forms.Button();
            this.ViewFinalScheduleButton = new System.Windows.Forms.Button();
            this.UserScheduleLabel = new System.Windows.Forms.Label();
            this.RequestTimeOffButton = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.EmployeeAvailabilitySubmissionGridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAvailabilitySubmissionGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitUserScheduleButton
            // 
            this.SubmitUserScheduleButton.Location = new System.Drawing.Point(308, 523);
            this.SubmitUserScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitUserScheduleButton.Name = "SubmitUserScheduleButton";
            this.SubmitUserScheduleButton.Size = new System.Drawing.Size(194, 28);
            this.SubmitUserScheduleButton.TabIndex = 32;
            this.SubmitUserScheduleButton.Text = "Submit Employee Schedule";
            this.SubmitUserScheduleButton.UseVisualStyleBackColor = true;
            // 
            // ViewFinalScheduleButton
            // 
            this.ViewFinalScheduleButton.Location = new System.Drawing.Point(129, 523);
            this.ViewFinalScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewFinalScheduleButton.Name = "ViewFinalScheduleButton";
            this.ViewFinalScheduleButton.Size = new System.Drawing.Size(145, 28);
            this.ViewFinalScheduleButton.TabIndex = 34;
            this.ViewFinalScheduleButton.Text = "View Final Schedule";
            this.ViewFinalScheduleButton.UseVisualStyleBackColor = true;
            // 
            // UserScheduleLabel
            // 
            this.UserScheduleLabel.AutoSize = true;
            this.UserScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserScheduleLabel.Location = new System.Drawing.Point(276, 9);
            this.UserScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserScheduleLabel.Name = "UserScheduleLabel";
            this.UserScheduleLabel.Size = new System.Drawing.Size(196, 25);
            this.UserScheduleLabel.TabIndex = 35;
            this.UserScheduleLabel.Text = "Employee Availability";
            this.UserScheduleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RequestTimeOffButton
            // 
            this.RequestTimeOffButton.Location = new System.Drawing.Point(535, 523);
            this.RequestTimeOffButton.Margin = new System.Windows.Forms.Padding(4);
            this.RequestTimeOffButton.Name = "RequestTimeOffButton";
            this.RequestTimeOffButton.Size = new System.Drawing.Size(128, 28);
            this.RequestTimeOffButton.TabIndex = 36;
            this.RequestTimeOffButton.Text = "Request Time Off";
            this.RequestTimeOffButton.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // EmployeeAvailabilitySubmissionGridview
            // 
            this.EmployeeAvailabilitySubmissionGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeAvailabilitySubmissionGridview.Location = new System.Drawing.Point(5, 50);
            this.EmployeeAvailabilitySubmissionGridview.Name = "EmployeeAvailabilitySubmissionGridview";
            this.EmployeeAvailabilitySubmissionGridview.RowTemplate.Height = 24;
            this.EmployeeAvailabilitySubmissionGridview.Size = new System.Drawing.Size(825, 442);
            this.EmployeeAvailabilitySubmissionGridview.TabIndex = 44;
            this.EmployeeAvailabilitySubmissionGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 795);
            this.Controls.Add(this.EmployeeAvailabilitySubmissionGridview);
            this.Controls.Add(this.RequestTimeOffButton);
            this.Controls.Add(this.UserScheduleLabel);
            this.Controls.Add(this.ViewFinalScheduleButton);
            this.Controls.Add(this.SubmitUserScheduleButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAvailabilitySubmissionGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitUserScheduleButton;
        private System.Windows.Forms.Button ViewFinalScheduleButton;
        private System.Windows.Forms.Label UserScheduleLabel;
        private System.Windows.Forms.Button RequestTimeOffButton;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView EmployeeAvailabilitySubmissionGridview;
    }
}