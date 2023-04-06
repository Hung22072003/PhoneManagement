using PhoneManagement.BLL;
using PhoneManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement.View
{
    public partial class Admin : Form
    {
        private string UserName;
        public Admin(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Panel_Profile.Visible)
            {
                Panel_Profile.Visible = false;
            }else
            {
                Panel_Profile.Visible = true;
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Panel_StaffManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Panel_StorageManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Panel_RevenueManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Panel_TradeHistory_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Label_StaffManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Label_StorageManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Label_RevenueManagement_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Label_TradeHistory_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SetUserInfo();
        }

        public void SetUserInfo()
        {
            ManageAccountBLL mab = new ManageAccountBLL();
            Account a = mab.GetAccountByUserName(this.UserName);
            Label_DisplayName.Text = a.DisplayName;
        }

        private void Label_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
