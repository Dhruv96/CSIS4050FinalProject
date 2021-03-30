
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
            this.labelBaggage = new System.Windows.Forms.Label();
            this.comboBoxBaggage = new System.Windows.Forms.ComboBox();
            this.labelSeatNum = new System.Windows.Forms.Label();
            this.comboBoxSeatNum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(494, 344);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(69, 19);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(396, 344);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 19);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAvailableFlights
            // 
            this.dataGridViewAvailableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableFlights.Location = new System.Drawing.Point(38, 130);
            this.dataGridViewAvailableFlights.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewAvailableFlights.Name = "dataGridViewAvailableFlights";
            this.dataGridViewAvailableFlights.RowHeadersWidth = 82;
            this.dataGridViewAvailableFlights.RowTemplate.Height = 41;
            this.dataGridViewAvailableFlights.Size = new System.Drawing.Size(526, 185);
            this.dataGridViewAvailableFlights.TabIndex = 10;
            // 
            // radioButtonOneWay
            // 
            this.radioButtonOneWay.AutoSize = true;
            this.radioButtonOneWay.Location = new System.Drawing.Point(38, 98);
            this.radioButtonOneWay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButtonOneWay.Name = "radioButtonOneWay";
            this.radioButtonOneWay.Size = new System.Drawing.Size(70, 17);
            this.radioButtonOneWay.TabIndex = 2;
            this.radioButtonOneWay.TabStop = true;
            this.radioButtonOneWay.Text = "One-Way";
            this.radioButtonOneWay.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundTrip
            // 
            this.radioButtonRoundTrip.AutoSize = true;
            this.radioButtonRoundTrip.Location = new System.Drawing.Point(142, 98);
            this.radioButtonRoundTrip.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButtonRoundTrip.Name = "radioButtonRoundTrip";
            this.radioButtonRoundTrip.Size = new System.Drawing.Size(78, 17);
            this.radioButtonRoundTrip.TabIndex = 3;
            this.radioButtonRoundTrip.TabStop = true;
            this.radioButtonRoundTrip.Text = "Round Trip";
            this.radioButtonRoundTrip.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Checked = false;
            this.dateTimePickerTo.Location = new System.Drawing.Point(336, 51);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(288, 51);
            this.labelDateTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(20, 13);
            this.labelDateTo.TabIndex = 5;
            this.labelDateTo.Text = "To";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(26, 51);
            this.labelDateFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(30, 13);
            this.labelDateFrom.TabIndex = 4;
            this.labelDateFrom.Text = "Date";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Checked = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(76, 51);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(198, 21);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 8;
            this.labelDestination.Text = "Destination";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(276, 21);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(114, 21);
            this.comboBoxDestination.TabIndex = 9;
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Location = new System.Drawing.Point(76, 20);
            this.comboBoxDepart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(114, 21);
            this.comboBoxDepart.TabIndex = 7;
            // 
            // labelDeapart
            // 
            this.labelDeapart.AutoSize = true;
            this.labelDeapart.Location = new System.Drawing.Point(26, 20);
            this.labelDeapart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeapart.Name = "labelDeapart";
            this.labelDeapart.Size = new System.Drawing.Size(39, 13);
            this.labelDeapart.TabIndex = 1;
            this.labelDeapart.Text = "Depart";
            // 
            // labelAirlines
            // 
            this.labelAirlines.AutoSize = true;
            this.labelAirlines.Location = new System.Drawing.Point(413, 23);
            this.labelAirlines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAirlines.Name = "labelAirlines";
            this.labelAirlines.Size = new System.Drawing.Size(40, 13);
            this.labelAirlines.TabIndex = 13;
            this.labelAirlines.Text = "Airlines";
            // 
            // comboBoxAirlines
            // 
            this.comboBoxAirlines.FormattingEnabled = true;
            this.comboBoxAirlines.Location = new System.Drawing.Point(474, 21);
            this.comboBoxAirlines.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxAirlines.Name = "comboBoxAirlines";
            this.comboBoxAirlines.Size = new System.Drawing.Size(124, 21);
            this.comboBoxAirlines.TabIndex = 14;
            // 
            // labelBaggage
            // 
            this.labelBaggage.AutoSize = true;
            this.labelBaggage.Location = new System.Drawing.Point(288, 99);
            this.labelBaggage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaggage.Name = "labelBaggage";
            this.labelBaggage.Size = new System.Drawing.Size(50, 13);
            this.labelBaggage.TabIndex = 0;
            this.labelBaggage.Text = "Baggage";
            // 
            // comboBoxBaggage
            // 
            this.comboBoxBaggage.FormattingEnabled = true;
            this.comboBoxBaggage.Location = new System.Drawing.Point(354, 99);
            this.comboBoxBaggage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxBaggage.Name = "comboBoxBaggage";
            this.comboBoxBaggage.Size = new System.Drawing.Size(42, 21);
            this.comboBoxBaggage.TabIndex = 16;
            // 
            // labelSeatNum
            // 
            this.labelSeatNum.AutoSize = true;
            this.labelSeatNum.Location = new System.Drawing.Point(432, 100);
            this.labelSeatNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeatNum.Name = "labelSeatNum";
            this.labelSeatNum.Size = new System.Drawing.Size(49, 13);
            this.labelSeatNum.TabIndex = 0;
            this.labelSeatNum.Text = "Seat No.";
            // 
            // comboBoxSeatNum
            // 
            this.comboBoxSeatNum.FormattingEnabled = true;
            this.comboBoxSeatNum.Location = new System.Drawing.Point(488, 100);
            this.comboBoxSeatNum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxSeatNum.Name = "comboBoxSeatNum";
            this.comboBoxSeatNum.Size = new System.Drawing.Size(41, 21);
            this.comboBoxSeatNum.TabIndex = 18;
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.comboBoxSeatNum);
            this.Controls.Add(this.labelSeatNum);
            this.Controls.Add(this.comboBoxBaggage);
            this.Controls.Add(this.labelBaggage);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Label labelBaggage;
        private System.Windows.Forms.ComboBox comboBoxBaggage;
        private System.Windows.Forms.Label labelSeatNum;
        private System.Windows.Forms.ComboBox comboBoxSeatNum;
    }
}

