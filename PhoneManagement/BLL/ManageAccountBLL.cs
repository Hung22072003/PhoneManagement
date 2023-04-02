using System;
using System.Collections.Generic;
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
    }
}
