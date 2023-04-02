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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textdangnhap_Click(object sender, EventArgs e)
        {
            if (Txb_Matkhau.Focused == false && Txb_Matkhau.Text == "")
            {
                Txb_Matkhau.Text = "Mật khẩu";
                Txb_Matkhau.ForeColor = SystemColors.ScrollBar;
            }
            Txb_Dangnhap.Text = "";

        }

        private void textMatkhau_Click(object sender, EventArgs e)
        {
            if(Txb_Dangnhap.Focused == false && Txb_Dangnhap.Text == "")
            {
                Txb_Dangnhap.Text = "Tên đăng nhập";
                Txb_Dangnhap.ForeColor = SystemColors.ScrollBar;

            }
            Txb_Matkhau.Text = "";
        }

        private void textdangnhap_TextChanged(object sender, EventArgs e)
        {
            Txb_Dangnhap.ForeColor = Color.Black;
        }

        private void textMatkhau_TextChanged(object sender, EventArgs e)
        {
            Txb_Matkhau.ForeColor = Color.Black;
        }

        private void Btn_Dangnhap_Click(object sender, EventArgs e)
        {
            ManageAccountBLL mal = new ManageAccountBLL();
            int result = mal.GetTypeAccount(Txb_Dangnhap.Text, Txb_Matkhau.Text);
            if(result == -1)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            if(result == 1)
            {
                User u = new User();
                u.ShowDialog();
            }
            if(result == 0)
            {
                Admin ad = new Admin();
                ad.ShowDialog();
            }
        }
    }
}
