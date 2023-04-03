using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement.View
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
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

        private void User_Click(object sender, EventArgs e)
        {
            Panel_Profile.Visible = false;
        }
    }
}
