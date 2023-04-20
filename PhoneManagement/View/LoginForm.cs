using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneManagement.BLL;

namespace PhoneManagement.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textdangnhap_Click(object sender, EventArgs e)
        {
            if (Txb_Matkhau.Focused == false && Txb_Matkhau.Text == "")
            {
                Txb_Matkhau.UseSystemPasswordChar = false;
                Txb_Matkhau.Text = "Mật khẩu";
                Txb_Matkhau.ForeColor = SystemColors.ScrollBar;
            }
            if (Txb_Dangnhap.Text == "Tên đăng nhập") Txb_Dangnhap.Text = "";

        }

        private void textMatkhau_Click(object sender, EventArgs e)
        {
            if(Txb_Dangnhap.Focused == false && Txb_Dangnhap.Text == "")
            {
                Txb_Dangnhap.Text = "Tên đăng nhập";
                Txb_Dangnhap.ForeColor = SystemColors.ScrollBar;

            }
            if (Txb_Matkhau.Text == "Mật khẩu") Txb_Matkhau.Text = "";
        }

        private void textdangnhap_TextChanged(object sender, EventArgs e)
        {
            Txb_Dangnhap.ForeColor = Color.Black;
        }

        private void textMatkhau_TextChanged(object sender, EventArgs e)
        {
            Txb_Matkhau.ForeColor = Color.Black;
            Txb_Matkhau.UseSystemPasswordChar = true;
        }

        private void Btn_Dangnhap_Click(object sender, EventArgs e)
        {
            ManageAccountBLL mal = new ManageAccountBLL();
            if ((Txb_Dangnhap.Text == "" || Txb_Dangnhap.Text == "Tên đăng nhập") && (Txb_Matkhau.Text == "" || Txb_Matkhau.Text == "Mật khẩu"))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            } 
            else if ((Txb_Dangnhap.Text == "" || Txb_Dangnhap.Text == "Tên đăng nhập") && (Txb_Matkhau.Text != "" || Txb_Matkhau.Text != "Mật khẩu")) {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else if ((Txb_Dangnhap.Text != "" || Txb_Dangnhap.Text != "Tên đăng nhập") && (Txb_Matkhau.Text == "" || Txb_Matkhau.Text == "Mật khẩu"))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                int result = mal.GetTypeAccount(Txb_Dangnhap.Text, Txb_Matkhau.Text);
                   
                if (result == 0)
                {
                    Admin u = new Admin(Txb_Dangnhap.Text);
                    this.Hide();
                    u.ShowDialog();
                    Txb_Dangnhap.Clear();
                    Txb_Matkhau.Clear();
                    this.Show();
                }
                else if (result == 1)
                {
                    User ad = new User();
                    this.Hide();
                    ad.ShowDialog();
                    Txb_Dangnhap.Clear();
                    Txb_Matkhau.Clear();
                    this.Show();
                } else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /*Btn_Dangnhap_Click(sender, e);*/
                /*if (Txb_Matkhau.Focused)
                {
                    if (Txb_Dangnhap.Focused == false && Txb_Dangnhap.Text == "")
                    {
                        Txb_Dangnhap.Text = "Tên đăng nhập";
                        Txb_Dangnhap.ForeColor = SystemColors.ScrollBar;                    }
                    if (Txb_Matkhau.Text == "Mật khẩu") Txb_Matkhau.Text = "";
                }*/
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, 0, 33, 50, 33);
            g.DrawLine(pen, 100, 33, 150, 33);
        }
    }
}
