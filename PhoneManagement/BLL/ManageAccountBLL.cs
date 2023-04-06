using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneManagement.DAL;
using PhoneManagement.DTO;

namespace PhoneManagement.BLL
{
    class ManageAccountBLL
    {
        public int GetTypeAccount(string UserName, string PassWord)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach(Account i in mad.GetAllAccount())
            {
                if(i.UserName == UserName && i.PassWord == PassWord)
                {
                    return i.TypeAccount;
                }
            }
            return -1;
        }

        public Account GetAccountByUserName(string UserName)
        {
            DBAccountDataContext dba = new DBAccountDataContext();
            Account a = dba.Accounts.Where(p => p.UserName == UserName).FirstOrDefault();
            return a;
        }
    }
}
