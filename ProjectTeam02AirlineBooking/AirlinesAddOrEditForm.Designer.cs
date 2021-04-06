
namespace ProjectTeam02AirlineBooking
{
    partial class AirlinesAddOrEditForm
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
            this.labelAirlineIdManage = new System.Windows.Forms.Label();
            this.textBoxAirlineIdManage = new System.Windows.Forms.TextBox();
            this.labelAirlineNameManage = new System.Windows.Forms.Label();
            this.textBoxAirlineNameManage = new System.Windows.Forms.TextBox();
            this.buttonAirlineManageAdd = new System.Windows.Forms.Button();
            this.buttonAirlineManageUpdate = new System.Windows.Forms.Button();
            this.labelAirlines = new System.Windows.Forms.Label();
            this.listBoxAirlineManageList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAirlineIdManage
            // 
            this.labelAirlineIdManage.AutoSize = true;
            this.labelAirlineIdManage.Location = new System.Drawing.Point(31, 311);
            this.labelAirlineIdManage.Name = "labelAirlineIdManage";
            this.labelAirlineIdManage.Size = new System.Drawing.Size(85, 24);
            this.labelAirlineIdManage.TabIndex = 1;
            this.labelAirlineIdManage.Text = "Airline ID";
            // 
            // textBoxAirlineIdManage
            // 
            this.textBoxAirlineIdManage.Location = new System.Drawing.Point(232, 311);
            this.textBoxAirlineIdManage.Name = "textBoxAirlineIdManage";
            this.textBoxAirlineIdManage.Size = new System.Drawing.Size(163, 29);
            this.textBoxAirlineIdManage.TabIndex = 2;
            // 
            // labelAirlineNameManage
            // 
            this.labelAirlineNameManage.AutoSize = true;
            this.labelAirlineNameManage.Location = new System.Drawing.Point(31, 371);
            this.labelAirlineNameManage.Name = "labelAirlineNameManage";
            this.labelAirlineNameManage.Size = new System.Drawing.Size(119, 24);
            this.labelAirlineNameManage.TabIndex = 3;
            this.labelAirlineNameManage.Text = "Airline Name";
            // 
            // textBoxAirlineNameManage
            // 
            this.textBoxAirlineNameManage.Location = new System.Drawing.Point(232, 367);
            this.textBoxAirlineNameManage.Name = "textBoxAirlineNameManage";
            this.textBoxAirlineNameManage.Size = new System.Drawing.Size(163, 29);
            this.textBoxAirlineNameManage.TabIndex = 4;
            // 
            // buttonAirlineManageAdd
            // 
            this.buttonAirlineManageAdd.Location = new System.Drawing.Point(64, 504);
            this.buttonAirlineManageAdd.Name = "buttonAirlineManageAdd";
            this.buttonAirlineManageAdd.Size = new System.Drawing.Size(118, 47);
            this.buttonAirlineManageAdd.TabIndex = 5;
            this.buttonAirlineManageAdd.Text = "Add";
            this.buttonAirlineManageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonAirlineManageUpdate
            // 
            this.buttonAirlineManageUpdate.Location = new System.Drawing.Point(310, 504);
            this.buttonAirlineManageUpdate.Name = "buttonAirlineManageUpdate";
            this.buttonAirlineManageUpdate.Size = new System.Drawing.Size(110, 47);
            this.buttonAirlineManageUpdate.TabIndex = 6;
            this.buttonAirlineManageUpdate.Text = "Update";
            this.buttonAirlineManageUpdate.UseVisualStyleBackColor = true;
            // 
            // labelAirlines
            // 
            this.labelAirlines.AutoSize = true;
            this.labelAirlines.Location = new System.Drawing.Point(22, 27);
            this.labelAirlines.Name = "labelAirlines";
            this.labelAirlines.Size = new System.Drawing.Size(72, 24);
            this.labelAirlines.TabIndex = 7;
            this.labelAirlines.Text = "Airlines";
            // 
            // listBoxAirlineManageList
            // 
            this.listBoxAirlineManageList.FormattingEnabled = true;
            this.listBoxAirlineManageList.ItemHeight = 24;
            this.listBoxAirlineManageList.Location = new System.Drawing.Point(27, 74);
            this.listBoxAirlineManageList.Name = "listBoxAirlineManageList";
            this.listBoxAirlineManageList.Size = new System.Drawing.Size(422, 220);
            this.listBoxAirlineManageList.TabIndex = 8;
            // 
            // AirlinesAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 628);
            this.Controls.Add(this.listBoxAirlineManageList);
            this.Controls.Add(this.labelAirlines);
            this.Controls.Add(this.buttonAirlineManageUpdate);
            this.Controls.Add(this.buttonAirlineManageAdd);
            this.Controls.Add(this.textBoxAirlineNameManage);
            this.Controls.Add(this.labelAirlineNameManage);
            this.Controls.Add(this.textBoxAirlineIdManage);
            this.Controls.Add(this.labelAirlineIdManage);
            this.Name = "AirlinesAddOrEditForm";
            this.Text = "AirlinesAddOrEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAirlineIdManage;
        private System.Windows.Forms.TextBox textBoxAirlineIdManage;
        private System.Windows.Forms.Label labelAirlineNameManage;
        private System.Windows.Forms.TextBox textBoxAirlineNameManage;
        private System.Windows.Forms.Button buttonAirlineManageAdd;
        private System.Windows.Forms.Button buttonAirlineManageUpdate;
        private System.Windows.Forms.Label labelAirlines;
        private System.Windows.Forms.ListBox listBoxAirlineManageList;
    }
}