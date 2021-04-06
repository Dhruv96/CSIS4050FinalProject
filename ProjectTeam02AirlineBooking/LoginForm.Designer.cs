
namespace ProjectTeam02AirlineBooking
{
    partial class LoginForm
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
            this.buttonLoginAsAdmin.Location = new System.Drawing.Point(165, 44);
            this.buttonLoginAsAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginAsAdmin.Name = "buttonLoginAsAdmin";
            this.buttonLoginAsAdmin.Size = new System.Drawing.Size(114, 31);
            this.buttonLoginAsAdmin.TabIndex = 0;
            this.buttonLoginAsAdmin.Text = "Login As Admin";
            this.buttonLoginAsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonLoginAsPassenger
            // 
            this.buttonLoginAsPassenger.Location = new System.Drawing.Point(165, 99);
            this.buttonLoginAsPassenger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginAsPassenger.Name = "buttonLoginAsPassenger";
            this.buttonLoginAsPassenger.Size = new System.Drawing.Size(114, 32);
            this.buttonLoginAsPassenger.TabIndex = 1;
            this.buttonLoginAsPassenger.Text = "Login As Passenger";
            this.buttonLoginAsPassenger.UseVisualStyleBackColor = true;
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 234);
            this.Controls.Add(this.buttonLoginAsPassenger);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginUserForm";
            this.Text = "Douglas Travel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginAsAdmin;
        private System.Windows.Forms.Button buttonLoginAsPassenger;
    }
}

