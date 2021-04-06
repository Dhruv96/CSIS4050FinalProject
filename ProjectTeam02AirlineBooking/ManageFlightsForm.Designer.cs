
namespace ProjectTeam02AirlineBooking
{
    partial class ManageFlightForm
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
            this.buttonFlightsInfo = new System.Windows.Forms.Button();
            this.buttonAirlinesInfo = new System.Windows.Forms.Button();
            this.buttonAirportsInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFlightsInfo
            // 
            this.buttonFlightsInfo.Location = new System.Drawing.Point(202, 100);
            this.buttonFlightsInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonFlightsInfo.Name = "buttonFlightsInfo";
            this.buttonFlightsInfo.Size = new System.Drawing.Size(138, 42);
            this.buttonFlightsInfo.TabIndex = 0;
            this.buttonFlightsInfo.Text = "Flights Info";
            this.buttonFlightsInfo.UseVisualStyleBackColor = true;
            // 
            // buttonAirlinesInfo
            // 
            this.buttonAirlinesInfo.Location = new System.Drawing.Point(202, 222);
            this.buttonAirlinesInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAirlinesInfo.Name = "buttonAirlinesInfo";
            this.buttonAirlinesInfo.Size = new System.Drawing.Size(138, 42);
            this.buttonAirlinesInfo.TabIndex = 1;
            this.buttonAirlinesInfo.Text = "Airlines Info";
            this.buttonAirlinesInfo.UseVisualStyleBackColor = true;
            // 
            // buttonAirportsInfo
            // 
            this.buttonAirportsInfo.Location = new System.Drawing.Point(202, 367);
            this.buttonAirportsInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAirportsInfo.Name = "buttonAirportsInfo";
            this.buttonAirportsInfo.Size = new System.Drawing.Size(138, 42);
            this.buttonAirportsInfo.TabIndex = 2;
            this.buttonAirportsInfo.Text = "Airports Info";
            this.buttonAirportsInfo.UseVisualStyleBackColor = true;
            // 
            // ManageFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 563);
            this.Controls.Add(this.buttonAirportsInfo);
            this.Controls.Add(this.buttonAirlinesInfo);
            this.Controls.Add(this.buttonFlightsInfo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageFlightForm";
            this.Text = "ManageFlightsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFlightsInfo;
        private System.Windows.Forms.Button buttonAirlinesInfo;
        private System.Windows.Forms.Button buttonAirportsInfo;
    }
}