
namespace ProjectTeam02AirlineBooking
{
    partial class Reports
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
            this.labelRevenue = new System.Windows.Forms.Label();
            this.labelAirlines = new System.Windows.Forms.Label();
            this.comboBoxAirlines = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.buttonGetRevenue = new System.Windows.Forms.Button();
            this.labelRevenueEarned = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRevenue
            // 
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Location = new System.Drawing.Point(24, 13);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(249, 25);
            this.labelRevenue.TabIndex = 0;
            this.labelRevenue.Text = "Revenue Collected From";
            // 
            // labelAirlines
            // 
            this.labelAirlines.AutoSize = true;
            this.labelAirlines.Location = new System.Drawing.Point(24, 82);
            this.labelAirlines.Name = "labelAirlines";
            this.labelAirlines.Size = new System.Drawing.Size(83, 25);
            this.labelAirlines.TabIndex = 1;
            this.labelAirlines.Text = "Airlines";
            // 
            // comboBoxAirlines
            // 
            this.comboBoxAirlines.FormattingEnabled = true;
            this.comboBoxAirlines.Location = new System.Drawing.Point(113, 79);
            this.comboBoxAirlines.Name = "comboBoxAirlines";
            this.comboBoxAirlines.Size = new System.Drawing.Size(201, 33);
            this.comboBoxAirlines.TabIndex = 2;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(24, 185);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(61, 25);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(111, 185);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(264, 31);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(487, 185);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(290, 31);
            this.dateTimePickerTo.TabIndex = 6;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(425, 185);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(37, 25);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To";
            // 
            // buttonGetRevenue
            // 
            this.buttonGetRevenue.Location = new System.Drawing.Point(29, 307);
            this.buttonGetRevenue.Name = "buttonGetRevenue";
            this.buttonGetRevenue.Size = new System.Drawing.Size(296, 52);
            this.buttonGetRevenue.TabIndex = 7;
            this.buttonGetRevenue.Text = "Get Revenue Earned";
            this.buttonGetRevenue.UseVisualStyleBackColor = true;
            // 
            // labelRevenueEarned
            // 
            this.labelRevenueEarned.AutoSize = true;
            this.labelRevenueEarned.Location = new System.Drawing.Point(401, 321);
            this.labelRevenueEarned.Name = "labelRevenueEarned";
            this.labelRevenueEarned.Size = new System.Drawing.Size(0, 25);
            this.labelRevenueEarned.TabIndex = 8;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRevenueEarned);
            this.Controls.Add(this.buttonGetRevenue);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxAirlines);
            this.Controls.Add(this.labelAirlines);
            this.Controls.Add(this.labelRevenue);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.Label labelAirlines;
        private System.Windows.Forms.ComboBox comboBoxAirlines;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button buttonGetRevenue;
        private System.Windows.Forms.Label labelRevenueEarned;
    }
}