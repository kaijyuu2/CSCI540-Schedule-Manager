namespace WindowsFormsApplication1
{
    partial class FinalScheduleForm
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
            this.FinalScheduleLabel = new System.Windows.Forms.Label();
            this.Employee2AvailabilityGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Employee2AvailabilityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalScheduleLabel
            // 
            this.FinalScheduleLabel.AutoSize = true;
            this.FinalScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScheduleLabel.Location = new System.Drawing.Point(234, 9);
            this.FinalScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalScheduleLabel.Name = "FinalScheduleLabel";
            this.FinalScheduleLabel.Size = new System.Drawing.Size(254, 25);
            this.FinalScheduleLabel.TabIndex = 29;
            this.FinalScheduleLabel.Text = "Final Schedule (Uneditable)";
            // 
            // Employee2AvailabilityGridView
            // 
            this.Employee2AvailabilityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee2AvailabilityGridView.Location = new System.Drawing.Point(2, 37);
            this.Employee2AvailabilityGridView.Name = "Employee2AvailabilityGridView";
            this.Employee2AvailabilityGridView.RowTemplate.Height = 24;
            this.Employee2AvailabilityGridView.Size = new System.Drawing.Size(736, 565);
            this.Employee2AvailabilityGridView.TabIndex = 171;
            // 
            // FinalScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 691);
            this.Controls.Add(this.Employee2AvailabilityGridView);
            this.Controls.Add(this.FinalScheduleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalScheduleForm";
            this.Text = "FinalScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Employee2AvailabilityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinalScheduleLabel;
        private System.Windows.Forms.DataGridView Employee2AvailabilityGridView;
    }
}