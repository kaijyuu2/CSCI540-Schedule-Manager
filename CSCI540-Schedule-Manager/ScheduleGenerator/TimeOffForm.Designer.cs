namespace ScheduleGenerator
{
    partial class TimeOffForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SubmitTimeOffButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // SubmitTimeOffButton
            // 
            this.SubmitTimeOffButton.Location = new System.Drawing.Point(94, 51);
            this.SubmitTimeOffButton.Name = "SubmitTimeOffButton";
            this.SubmitTimeOffButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitTimeOffButton.TabIndex = 1;
            this.SubmitTimeOffButton.Text = "Submit";
            this.SubmitTimeOffButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the days you request off one at a time.";
            // 
            // TimeOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitTimeOffButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TimeOffForm";
            this.Text = "TimeOffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeOffForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SubmitTimeOffButton;
        private System.Windows.Forms.Label label1;
    }
}