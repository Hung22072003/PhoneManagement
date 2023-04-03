
namespace PhoneManagement.View
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Profile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Panel_Profile
            // 
            this.Panel_Profile.BackColor = System.Drawing.Color.White;
            this.Panel_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Profile.Controls.Add(this.label5);
            this.Panel_Profile.Controls.Add(this.label4);
            this.Panel_Profile.Controls.Add(this.label3);
            this.Panel_Profile.Controls.Add(this.label2);
            this.Panel_Profile.Controls.Add(this.label1);
            this.Panel_Profile.Location = new System.Drawing.Point(12, 68);
            this.Panel_Profile.Name = "Panel_Profile";
            this.Panel_Profile.Size = new System.Drawing.Size(187, 111);
            this.Panel_Profile.TabIndex = 1;
            this.Panel_Profile.Tag = "111";
            this.Panel_Profile.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hưng Trần";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đăng xuất";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.Panel_Profile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Click += new System.EventHandler(this.User_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_Profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}