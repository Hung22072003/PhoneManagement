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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Dangnhap = new System.Windows.Forms.Button();
            this.Txb_Matkhau = new System.Windows.Forms.TextBox();
            this.Txb_Dangnhap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Btn_Dangnhap);
            this.panel1.Controls.Add(this.Txb_Matkhau);
            this.panel1.Controls.Add(this.Txb_Dangnhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 483);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(68, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 3);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(68, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 3);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PhoneManagement.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(68, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 79);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            // 
            // Btn_Dangnhap
            // 
            this.Btn_Dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dangnhap.Location = new System.Drawing.Point(111, 332);
            this.Btn_Dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dangnhap.Name = "Btn_Dangnhap";
            this.Btn_Dangnhap.Size = new System.Drawing.Size(127, 40);
            this.Btn_Dangnhap.TabIndex = 3;
            this.Btn_Dangnhap.Text = "Đăng nhập";
            this.Btn_Dangnhap.UseVisualStyleBackColor = false;
            this.Btn_Dangnhap.Click += new System.EventHandler(this.Btn_Dangnhap_Click);
            // 
            // Txb_Matkhau
            // 
            this.Txb_Matkhau.BackColor = System.Drawing.Color.White;
            this.Txb_Matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Matkhau.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Txb_Matkhau.Location = new System.Drawing.Point(68, 254);
            this.Txb_Matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Matkhau.Name = "Txb_Matkhau";
            this.Txb_Matkhau.Size = new System.Drawing.Size(170, 20);
            this.Txb_Matkhau.TabIndex = 2;
            this.Txb_Matkhau.Text = "Mật khẩu";
            this.Txb_Matkhau.Click += new System.EventHandler(this.textMatkhau_Click);
            this.Txb_Matkhau.TextChanged += new System.EventHandler(this.textMatkhau_TextChanged);
            // 
            // Txb_Dangnhap
            // 
            this.Txb_Dangnhap.BackColor = System.Drawing.Color.White;
            this.Txb_Dangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Dangnhap.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Txb_Dangnhap.Location = new System.Drawing.Point(68, 200);
            this.Txb_Dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Dangnhap.Name = "Txb_Dangnhap";
            this.Txb_Dangnhap.Size = new System.Drawing.Size(170, 20);
            this.Txb_Dangnhap.TabIndex = 1;
            this.Txb_Dangnhap.Text = "Tên đăng nhập";
            this.Txb_Dangnhap.Click += new System.EventHandler(this.textdangnhap_Click);
            this.Txb_Dangnhap.TextChanged += new System.EventHandler(this.textdangnhap_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(881, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 31);
            this.button1.TabIndex = 4;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Dangnhap;
        private System.Windows.Forms.TextBox Txb_Matkhau;
        private System.Windows.Forms.TextBox Txb_Dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}