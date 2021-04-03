
namespace ProjectTeam02AirlineBooking
{
    partial class LoginUserForm
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
            this.buttonLoginAsAdmin = new System.Windows.Forms.Button();
            this.buttonLoginAsPassenger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginAsAdmin
            // 
            this.buttonLoginAsAdmin.Location = new System.Drawing.Point(330, 85);
            this.buttonLoginAsAdmin.Name = "buttonLoginAsAdmin";
            this.buttonLoginAsAdmin.Size = new System.Drawing.Size(229, 60);
            this.buttonLoginAsAdmin.TabIndex = 0;
            this.buttonLoginAsAdmin.Text = "Login As Admin";
            this.buttonLoginAsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonLoginAsPassenger
            // 
            this.buttonLoginAsPassenger.Location = new System.Drawing.Point(330, 190);
            this.buttonLoginAsPassenger.Name = "buttonLoginAsPassenger";
            this.buttonLoginAsPassenger.Size = new System.Drawing.Size(229, 62);
            this.buttonLoginAsPassenger.TabIndex = 1;
            this.buttonLoginAsPassenger.Text = "Login As Passenger";
            this.buttonLoginAsPassenger.UseVisualStyleBackColor = true;
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.buttonLoginAsPassenger);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Name = "LoginUserForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginAsAdmin;
        private System.Windows.Forms.Button buttonLoginAsPassenger;
    }
}

