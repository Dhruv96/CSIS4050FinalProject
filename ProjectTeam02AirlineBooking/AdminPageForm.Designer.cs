
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
            this.buttonBackupDB = new System.Windows.Forms.Button();
            this.buttonRestoreDB = new System.Windows.Forms.Button();
            this.buttonGetReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageFlights
            // 
            this.buttonManageFlights.Location = new System.Drawing.Point(216, 70);
            this.buttonManageFlights.Margin = new System.Windows.Forms.Padding(6);
            this.buttonManageFlights.Name = "buttonManageFlights";
            this.buttonManageFlights.Size = new System.Drawing.Size(208, 52);
            this.buttonManageFlights.TabIndex = 0;
            this.buttonManageFlights.Text = "Manage Flights";
            this.buttonManageFlights.UseVisualStyleBackColor = true;
            // 
            // buttonManageBookings
            // 
            this.buttonManageBookings.Location = new System.Drawing.Point(216, 147);
            this.buttonManageBookings.Margin = new System.Windows.Forms.Padding(6);
            this.buttonManageBookings.Name = "buttonManageBookings";
            this.buttonManageBookings.Size = new System.Drawing.Size(208, 52);
            this.buttonManageBookings.TabIndex = 1;
            this.buttonManageBookings.Text = "Manage Bookings";
            this.buttonManageBookings.UseVisualStyleBackColor = true;
            // 
            // buttonBackupDB
            // 
            this.buttonBackupDB.Location = new System.Drawing.Point(216, 234);
            this.buttonBackupDB.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBackupDB.Name = "buttonBackupDB";
            this.buttonBackupDB.Size = new System.Drawing.Size(208, 52);
            this.buttonBackupDB.TabIndex = 2;
            this.buttonBackupDB.Text = "Backup Database";
            this.buttonBackupDB.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDB
            // 
            this.buttonRestoreDB.Location = new System.Drawing.Point(216, 312);
            this.buttonRestoreDB.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRestoreDB.Name = "buttonRestoreDB";
            this.buttonRestoreDB.Size = new System.Drawing.Size(208, 52);
            this.buttonRestoreDB.TabIndex = 3;
            this.buttonRestoreDB.Text = "Restore Database";
            this.buttonRestoreDB.UseVisualStyleBackColor = true;
            // 
            // buttonGetReports
            // 
            this.buttonGetReports.Location = new System.Drawing.Point(216, 390);
            this.buttonGetReports.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGetReports.Name = "buttonGetReports";
            this.buttonGetReports.Size = new System.Drawing.Size(208, 52);
            this.buttonGetReports.TabIndex = 4;
            this.buttonGetReports.Text = "Get Reports";
            this.buttonGetReports.UseVisualStyleBackColor = true;
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 529);
            this.Controls.Add(this.buttonGetReports);
            this.Controls.Add(this.buttonRestoreDB);
            this.Controls.Add(this.buttonBackupDB);
            this.Controls.Add(this.buttonManageBookings);
            this.Controls.Add(this.buttonManageFlights);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminPageForm";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageFlights;
        private System.Windows.Forms.Button buttonManageBookings;
        private System.Windows.Forms.Button buttonBackupDB;
        private System.Windows.Forms.Button buttonRestoreDB;
        private System.Windows.Forms.Button buttonGetReports;
    }
}