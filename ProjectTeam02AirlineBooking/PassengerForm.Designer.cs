
namespace ProjectTeam02AirlineBooking
{
    partial class PassengerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewAvailableFlights = new System.Windows.Forms.DataGridView();
            this.radioButtonOneWay = new System.Windows.Forms.RadioButton();
            this.radioButtonRoundTrip = new System.Windows.Forms.RadioButton();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.labelDeapart = new System.Windows.Forms.Label();
            this.labelAirlines = new System.Windows.Forms.Label();
            this.comboBoxAirlines = new System.Windows.Forms.ComboBox();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1271, 668);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(138, 37);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1075, 668);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 37);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAvailableFlights
            // 
            this.dataGridViewAvailableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableFlights.Location = new System.Drawing.Point(43, 250);
            this.dataGridViewAvailableFlights.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewAvailableFlights.Name = "dataGridViewAvailableFlights";
            this.dataGridViewAvailableFlights.RowHeadersWidth = 82;
            this.dataGridViewAvailableFlights.RowTemplate.Height = 41;
            this.dataGridViewAvailableFlights.Size = new System.Drawing.Size(1840, 356);
            this.dataGridViewAvailableFlights.TabIndex = 10;
            // 
            // radioButtonOneWay
            // 
            this.radioButtonOneWay.AutoSize = true;
            this.radioButtonOneWay.Location = new System.Drawing.Point(76, 188);
            this.radioButtonOneWay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonOneWay.Name = "radioButtonOneWay";
            this.radioButtonOneWay.Size = new System.Drawing.Size(133, 29);
            this.radioButtonOneWay.TabIndex = 2;
            this.radioButtonOneWay.TabStop = true;
            this.radioButtonOneWay.Text = "One-Way";
            this.radioButtonOneWay.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundTrip
            // 
            this.radioButtonRoundTrip.AutoSize = true;
            this.radioButtonRoundTrip.Location = new System.Drawing.Point(284, 188);
            this.radioButtonRoundTrip.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonRoundTrip.Name = "radioButtonRoundTrip";
            this.radioButtonRoundTrip.Size = new System.Drawing.Size(149, 29);
            this.radioButtonRoundTrip.TabIndex = 3;
            this.radioButtonRoundTrip.TabStop = true;
            this.radioButtonRoundTrip.Text = "Round Trip";
            this.radioButtonRoundTrip.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Checked = false;
            this.dateTimePickerTo.Location = new System.Drawing.Point(672, 98);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(370, 31);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(576, 98);
            this.labelDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(37, 25);
            this.labelDateTo.TabIndex = 5;
            this.labelDateTo.Text = "To";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(52, 98);
            this.labelDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(57, 25);
            this.labelDateFrom.TabIndex = 4;
            this.labelDateFrom.Text = "Date";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Checked = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(152, 98);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(370, 31);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(619, 38);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(120, 25);
            this.labelDestination.TabIndex = 8;
            this.labelDestination.Text = "Destination";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(768, 36);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(457, 33);
            this.comboBoxDestination.TabIndex = 9;
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Location = new System.Drawing.Point(136, 36);
            this.comboBoxDepart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(449, 33);
            this.comboBoxDepart.TabIndex = 7;
            // 
            // labelDeapart
            // 
            this.labelDeapart.AutoSize = true;
            this.labelDeapart.Location = new System.Drawing.Point(52, 38);
            this.labelDeapart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeapart.Name = "labelDeapart";
            this.labelDeapart.Size = new System.Drawing.Size(76, 25);
            this.labelDeapart.TabIndex = 1;
            this.labelDeapart.Text = "Depart";
            // 
            // labelAirlines
            // 
            this.labelAirlines.AutoSize = true;
            this.labelAirlines.Location = new System.Drawing.Point(1326, 36);
            this.labelAirlines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAirlines.Name = "labelAirlines";
            this.labelAirlines.Size = new System.Drawing.Size(83, 25);
            this.labelAirlines.TabIndex = 13;
            this.labelAirlines.Text = "Airlines";
            // 
            // comboBoxAirlines
            // 
            this.comboBoxAirlines.FormattingEnabled = true;
            this.comboBoxAirlines.Location = new System.Drawing.Point(1433, 36);
            this.comboBoxAirlines.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxAirlines.Name = "comboBoxAirlines";
            this.comboBoxAirlines.Size = new System.Drawing.Size(440, 33);
            this.comboBoxAirlines.TabIndex = 14;
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Location = new System.Drawing.Point(449, 188);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(316, 31);
            this.returnDateTimePicker.TabIndex = 19;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Location = new System.Drawing.Point(786, 190);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(127, 25);
            this.returnLabel.TabIndex = 20;
            this.returnLabel.Text = "Return Date";
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 744);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.comboBoxAirlines);
            this.Controls.Add(this.labelAirlines);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.dataGridViewAvailableFlights);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.comboBoxDepart);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.radioButtonRoundTrip);
            this.Controls.Add(this.radioButtonOneWay);
            this.Controls.Add(this.labelDeapart);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "PassengerForm";
            this.Text = "Douglas Travel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewAvailableFlights;
        private System.Windows.Forms.RadioButton radioButtonOneWay;
        private System.Windows.Forms.RadioButton radioButtonRoundTrip;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.Label labelDeapart;
        private System.Windows.Forms.Label labelAirlines;
        private System.Windows.Forms.ComboBox comboBoxAirlines;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label returnLabel;
    }
}

