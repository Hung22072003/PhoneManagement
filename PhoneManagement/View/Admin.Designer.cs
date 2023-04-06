
using PhoneManagement.DTO;

namespace PhoneManagement.View
{
    partial class Admin
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
            this.Panel_Profile = new System.Windows.Forms.Panel();
            this.Label_SignOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_DisplayName = new System.Windows.Forms.Label();
            this.Label_StaffManagement = new System.Windows.Forms.Label();
            this.Label_StorageManagement = new System.Windows.Forms.Label();
            this.Label_RevenueManagement = new System.Windows.Forms.Label();
            this.Label_TradeHistory = new System.Windows.Forms.Label();
            this.Panel_StaffManagement = new System.Windows.Forms.Panel();
            this.Panel_TradeHistory = new System.Windows.Forms.Panel();
            this.Panel_RevenueManagement = new System.Windows.Forms.Panel();
            this.Panel_StorageManagement = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Profile
            // 
            this.Panel_Profile.BackColor = System.Drawing.Color.White;
            this.Panel_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Profile.Controls.Add(this.Label_SignOut);
            this.Panel_Profile.Controls.Add(this.label4);
            this.Panel_Profile.Controls.Add(this.label3);
            this.Panel_Profile.Controls.Add(this.label2);
            this.Panel_Profile.Controls.Add(this.Label_DisplayName);
            this.Panel_Profile.Location = new System.Drawing.Point(12, 68);
            this.Panel_Profile.Name = "Panel_Profile";
            this.Panel_Profile.Size = new System.Drawing.Size(187, 111);
            this.Panel_Profile.TabIndex = 1;
            this.Panel_Profile.Tag = "111";
            this.Panel_Profile.Visible = false;
            // 
            // Label_SignOut
            // 
            this.Label_SignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SignOut.Location = new System.Drawing.Point(-1, 68);
            this.Label_SignOut.Name = "Label_SignOut";
            this.Label_SignOut.Size = new System.Drawing.Size(187, 38);
            this.Label_SignOut.TabIndex = 4;
            this.Label_SignOut.Text = "Đăng xuất";
            this.Label_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_SignOut.Click += new System.EventHandler(this.Label_SignOut_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-1, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 3);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xem thông tin cá nhân";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 3);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Label_DisplayName
            // 
            this.Label_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DisplayName.Location = new System.Drawing.Point(3, -7);
            this.Label_DisplayName.Name = "Label_DisplayName";
            this.Label_DisplayName.Size = new System.Drawing.Size(183, 34);
            this.Label_DisplayName.TabIndex = 0;
            this.Label_DisplayName.Text = "Người dùng";
            this.Label_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_StaffManagement
            // 
            this.Label_StaffManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_StaffManagement.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StaffManagement.Location = new System.Drawing.Point(96, 277);
            this.Label_StaffManagement.Name = "Label_StaffManagement";
            this.Label_StaffManagement.Size = new System.Drawing.Size(110, 46);
            this.Label_StaffManagement.TabIndex = 4;
            this.Label_StaffManagement.Text = "Quản lý nhân viên";
            this.Label_StaffManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_StaffManagement.Click += new System.EventHandler(this.Label_StaffManagement_Click);
            // 
            // Label_StorageManagement
            // 
            this.Label_StorageManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_StorageManagement.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StorageManagement.Location = new System.Drawing.Point(278, 277);
            this.Label_StorageManagement.Name = "Label_StorageManagement";
            this.Label_StorageManagement.Size = new System.Drawing.Size(112, 46);
            this.Label_StorageManagement.TabIndex = 5;
            this.Label_StorageManagement.Text = "Quản lý kho hàng";
            this.Label_StorageManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_StorageManagement.Click += new System.EventHandler(this.Label_StorageManagement_Click);
            // 
            // Label_RevenueManagement
            // 
            this.Label_RevenueManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_RevenueManagement.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RevenueManagement.Location = new System.Drawing.Point(450, 277);
            this.Label_RevenueManagement.Name = "Label_RevenueManagement";
            this.Label_RevenueManagement.Size = new System.Drawing.Size(112, 46);
            this.Label_RevenueManagement.TabIndex = 6;
            this.Label_RevenueManagement.Text = "Quản lý doanh thu";
            this.Label_RevenueManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_RevenueManagement.Click += new System.EventHandler(this.Label_RevenueManagement_Click);
            // 
            // Label_TradeHistory
            // 
            this.Label_TradeHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_TradeHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TradeHistory.Location = new System.Drawing.Point(620, 277);
            this.Label_TradeHistory.Name = "Label_TradeHistory";
            this.Label_TradeHistory.Size = new System.Drawing.Size(127, 46);
            this.Label_TradeHistory.TabIndex = 7;
            this.Label_TradeHistory.Text = "Xem lịch xử giao dịch";
            this.Label_TradeHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_TradeHistory.Click += new System.EventHandler(this.Label_TradeHistory_Click);
            // 
            // Panel_StaffManagement
            // 
            this.Panel_StaffManagement.BackgroundImage = global::PhoneManagement.Properties.Resources.staffmanagement;
            this.Panel_StaffManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_StaffManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_StaffManagement.Location = new System.Drawing.Point(96, 129);
            this.Panel_StaffManagement.Name = "Panel_StaffManagement";
            this.Panel_StaffManagement.Size = new System.Drawing.Size(110, 125);
            this.Panel_StaffManagement.TabIndex = 2;
            this.Panel_StaffManagement.Click += new System.EventHandler(this.Panel_StaffManagement_Click);
            // 
            // Panel_TradeHistory
            // 
            this.Panel_TradeHistory.BackgroundImage = global::PhoneManagement.Properties.Resources.trade_history;
            this.Panel_TradeHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_TradeHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_TradeHistory.Location = new System.Drawing.Point(613, 132);
            this.Panel_TradeHistory.Name = "Panel_TradeHistory";
            this.Panel_TradeHistory.Size = new System.Drawing.Size(110, 125);
            this.Panel_TradeHistory.TabIndex = 3;
            this.Panel_TradeHistory.Click += new System.EventHandler(this.Panel_TradeHistory_Click);
            // 
            // Panel_RevenueManagement
            // 
            this.Panel_RevenueManagement.BackgroundImage = global::PhoneManagement.Properties.Resources.revenue;
            this.Panel_RevenueManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_RevenueManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_RevenueManagement.Location = new System.Drawing.Point(454, 132);
            this.Panel_RevenueManagement.Name = "Panel_RevenueManagement";
            this.Panel_RevenueManagement.Size = new System.Drawing.Size(110, 125);
            this.Panel_RevenueManagement.TabIndex = 3;
            this.Panel_RevenueManagement.Click += new System.EventHandler(this.Panel_RevenueManagement_Click);
            // 
            // Panel_StorageManagement
            // 
            this.Panel_StorageManagement.BackgroundImage = global::PhoneManagement.Properties.Resources.storage;
            this.Panel_StorageManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_StorageManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_StorageManagement.Location = new System.Drawing.Point(268, 132);
            this.Panel_StorageManagement.Name = "Panel_StorageManagement";
            this.Panel_StorageManagement.Size = new System.Drawing.Size(122, 125);
            this.Panel_StorageManagement.TabIndex = 3;
            this.Panel_StorageManagement.Click += new System.EventHandler(this.Panel_StorageManagement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PhoneManagement.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(195)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_Profile);
            this.Controls.Add(this.Label_TradeHistory);
            this.Controls.Add(this.Label_RevenueManagement);
            this.Controls.Add(this.Label_StorageManagement);
            this.Controls.Add(this.Panel_StaffManagement);
            this.Controls.Add(this.Label_StaffManagement);
            this.Controls.Add(this.Panel_TradeHistory);
            this.Controls.Add(this.Panel_RevenueManagement);
            this.Controls.Add(this.Panel_StorageManagement);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Click += new System.EventHandler(this.Admin_Click);
            this.Panel_Profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Profile;
        private System.Windows.Forms.Label Label_DisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_SignOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_StaffManagement;
        private System.Windows.Forms.Panel Panel_StorageManagement;
        private System.Windows.Forms.Panel Panel_RevenueManagement;
        private System.Windows.Forms.Panel Panel_TradeHistory;
        private System.Windows.Forms.Label Label_StaffManagement;
        private System.Windows.Forms.Label Label_StorageManagement;
        private System.Windows.Forms.Label Label_RevenueManagement;
        private System.Windows.Forms.Label Label_TradeHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}