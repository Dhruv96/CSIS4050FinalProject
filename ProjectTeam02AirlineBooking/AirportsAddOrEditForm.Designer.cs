
namespace ProjectTeam02AirlineBooking
{
    partial class AirportsAddOrEditForm
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
            this.labelAirportMangeList = new System.Windows.Forms.Label();
            this.listBoxAirportList = new System.Windows.Forms.ListBox();
            this.labelAirportIdManage = new System.Windows.Forms.Label();
            this.textBoxAirportIdManage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAirportNameManage = new System.Windows.Forms.TextBox();
            this.buttonAirportManageAdd = new System.Windows.Forms.Button();
            this.buttonAirportManageUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAirportMangeList
            // 
            this.labelAirportMangeList.AutoSize = true;
            this.labelAirportMangeList.Location = new System.Drawing.Point(39, 38);
            this.labelAirportMangeList.Name = "labelAirportMangeList";
            this.labelAirportMangeList.Size = new System.Drawing.Size(138, 44);
            this.labelAirportMangeList.TabIndex = 0;
            this.labelAirportMangeList.Text = "Airports";
            // 
            // listBoxAirportList
            // 
            this.listBoxAirportList.FormattingEnabled = true;
            this.listBoxAirportList.ItemHeight = 24;
            this.listBoxAirportList.Location = new System.Drawing.Point(44, 86);
            this.listBoxAirportList.Name = "listBoxAirportList";
            this.listBoxAirportList.Size = new System.Drawing.Size(503, 292);
            this.listBoxAirportList.TabIndex = 1;
            // 
            // labelAirportIdManage
            // 
            this.labelAirportIdManage.AutoSize = true;
            this.labelAirportIdManage.Location = new System.Drawing.Point(79, 420);
            this.labelAirportIdManage.Name = "labelAirportIdManage";
            this.labelAirportIdManage.Size = new System.Drawing.Size(93, 25);
            this.labelAirportIdManage.TabIndex = 2;
            this.labelAirportIdManage.Text = "Airport ID";
            // 
            // textBoxAirportIdManage
            // 
            this.textBoxAirportIdManage.Location = new System.Drawing.Point(251, 420);
            this.textBoxAirportIdManage.Name = "textBoxAirportIdManage";
            this.textBoxAirportIdManage.Size = new System.Drawing.Size(197, 29);
            this.textBoxAirportIdManage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Airport Name";
            // 
            // textBoxAirportNameManage
            // 
            this.textBoxAirportNameManage.Location = new System.Drawing.Point(251, 473);
            this.textBoxAirportNameManage.Name = "textBoxAirportNameManage";
            this.textBoxAirportNameManage.Size = new System.Drawing.Size(197, 29);
            this.textBoxAirportNameManage.TabIndex = 5;
            // 
            // buttonAirportManageAdd
            // 
            this.buttonAirportManageAdd.Location = new System.Drawing.Point(104, 611);
            this.buttonAirportManageAdd.Name = "buttonAirportManageAdd";
            this.buttonAirportManageAdd.Size = new System.Drawing.Size(112, 48);
            this.buttonAirportManageAdd.TabIndex = 6;
            this.buttonAirportManageAdd.Text = "Add";
            this.buttonAirportManageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonAirportManageUpdate
            // 
            this.buttonAirportManageUpdate.Location = new System.Drawing.Point(332, 611);
            this.buttonAirportManageUpdate.Name = "buttonAirportManageUpdate";
            this.buttonAirportManageUpdate.Size = new System.Drawing.Size(116, 48);
            this.buttonAirportManageUpdate.TabIndex = 7;
            this.buttonAirportManageUpdate.Text = "Update";
            this.buttonAirportManageUpdate.UseVisualStyleBackColor = true;
            // 
            // AirportsAddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 712);
            this.Controls.Add(this.buttonAirportManageUpdate);
            this.Controls.Add(this.buttonAirportManageAdd);
            this.Controls.Add(this.textBoxAirportNameManage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAirportIdManage);
            this.Controls.Add(this.labelAirportIdManage);
            this.Controls.Add(this.listBoxAirportList);
            this.Controls.Add(this.labelAirportMangeList);
            this.Name = "AirportsAddOrEditForm";
            this.Text = "AirportsAddOrEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAirportMangeList;
        private System.Windows.Forms.ListBox listBoxAirportList;
        private System.Windows.Forms.Label labelAirportIdManage;
        private System.Windows.Forms.TextBox textBoxAirportIdManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAirportNameManage;
        private System.Windows.Forms.Button buttonAirportManageAdd;
        private System.Windows.Forms.Button buttonAirportManageUpdate;
    }
}