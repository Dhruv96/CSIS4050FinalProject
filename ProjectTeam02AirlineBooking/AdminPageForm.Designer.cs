
namespace ProjectTeam02AirlineBooking
{
    partial class AdminPageForm
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
            this.buttonManageFlights = new System.Windows.Forms.Button();
            this.buttonManageBookings = new System.Windows.Forms.Button();
            this.buttonBackToLoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageFlights
            // 
            this.buttonManageFlights.Location = new System.Drawing.Point(108, 49);
            this.buttonManageFlights.Name = "buttonManageFlights";
            this.buttonManageFlights.Size = new System.Drawing.Size(104, 27);
            this.buttonManageFlights.TabIndex = 0;
            this.buttonManageFlights.Text = "Manage Flights";
            this.buttonManageFlights.UseVisualStyleBackColor = true;
            // 
            // buttonManageBookings
            // 
            this.buttonManageBookings.Location = new System.Drawing.Point(108, 109);
            this.buttonManageBookings.Name = "buttonManageBookings";
            this.buttonManageBookings.Size = new System.Drawing.Size(104, 27);
            this.buttonManageBookings.TabIndex = 1;
            this.buttonManageBookings.Text = "Manage Bookings";
            this.buttonManageBookings.UseVisualStyleBackColor = true;
            // 
            // buttonBackToLoginForm
            // 
            this.buttonBackToLoginForm.Location = new System.Drawing.Point(124, 231);
            this.buttonBackToLoginForm.Name = "buttonBackToLoginForm";
            this.buttonBackToLoginForm.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToLoginForm.TabIndex = 2;
            this.buttonBackToLoginForm.Text = "Back";
            this.buttonBackToLoginForm.UseVisualStyleBackColor = true;
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.Controls.Add(this.buttonBackToLoginForm);
            this.Controls.Add(this.buttonManageBookings);
            this.Controls.Add(this.buttonManageFlights);
            this.Name = "AdminPageForm";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageFlights;
        private System.Windows.Forms.Button buttonManageBookings;
        private System.Windows.Forms.Button buttonBackToLoginForm;
    }
}