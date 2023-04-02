namespace PhoneManagement.View
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Dangnhap = new System.Windows.Forms.Button();
            this.Txb_Matkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_Dangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Dangnhap);
            this.panel1.Controls.Add(this.Txb_Matkhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txb_Dangnhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 551);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(68, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 2);
            this.label3.TabIndex = 12;
            this.label3.Text = "asasasass";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PhoneManagement.Properties.Resources.nguoi;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(133, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 93);
            this.panel2.TabIndex = 11;
            // 
            // Btn_Dangnhap
            // 
            this.Btn_Dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dangnhap.Location = new System.Drawing.Point(116, 350);
            this.Btn_Dangnhap.Name = "Btn_Dangnhap";
            this.Btn_Dangnhap.Size = new System.Drawing.Size(110, 33);
            this.Btn_Dangnhap.TabIndex = 7;
            this.Btn_Dangnhap.Text = "Đăng nhập";
            this.Btn_Dangnhap.UseVisualStyleBackColor = false;
            this.Btn_Dangnhap.Click += new System.EventHandler(this.Btn_Dangnhap_Click);
            // 
            // Txb_Matkhau
            // 
            this.Txb_Matkhau.BackColor = System.Drawing.Color.White;
            this.Txb_Matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_Matkhau.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Txb_Matkhau.Location = new System.Drawing.Point(68, 287);
            this.Txb_Matkhau.Name = "Txb_Matkhau";
            this.Txb_Matkhau.Size = new System.Drawing.Size(180, 19);
            this.Txb_Matkhau.TabIndex = 6;
            this.Txb_Matkhau.TabStop = false;
            this.Txb_Matkhau.Text = "Mật khẩu";
            this.Txb_Matkhau.Click += new System.EventHandler(this.textMatkhau_Click);
            this.Txb_Matkhau.TextChanged += new System.EventHandler(this.textMatkhau_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(68, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 2);
            this.label4.TabIndex = 5;
            this.label4.Text = "asasasass";
            // 
            // Txb_Dangnhap
            // 
            this.Txb_Dangnhap.BackColor = System.Drawing.Color.White;
            this.Txb_Dangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_Dangnhap.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Txb_Dangnhap.Location = new System.Drawing.Point(68, 233);
            this.Txb_Dangnhap.Name = "Txb_Dangnhap";
            this.Txb_Dangnhap.Size = new System.Drawing.Size(180, 19);
            this.Txb_Dangnhap.TabIndex = 4;
            this.Txb_Dangnhap.TabStop = false;
            this.Txb_Dangnhap.Text = "Tên đăng nhập";
            this.Txb_Dangnhap.Click += new System.EventHandler(this.textdangnhap_Click);
            this.Txb_Dangnhap.TextChanged += new System.EventHandler(this.textdangnhap_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(220, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 3);
            this.label2.TabIndex = 2;
            this.label2.Text = "asasasass";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(51, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 3);
            this.label1.TabIndex = 1;
            this.label1.Text = "asasasass";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(951, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhoneManagement.Properties.Resources.Screenshot__553_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Dangnhap;
        private System.Windows.Forms.TextBox Txb_Matkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_Dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}