using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneManagement.DAL
{
    internal class ManageAccountDAL
    {
        public Account GetAccountByDataRow(DataRow row)
        {
            return new Account
            {
                UserName = row["UserName"].ToString(),
                PassWord = row["PassWord"].ToString(),
                DisplayName = row["DisplayName"].ToString(),
                TypeAccount = Convert.ToInt32(row["TypeAccount"].ToString()),
            };
        }
        public List<Account> GetAllAccount()
        {
            List<Account> listAccount = new List<Account>();
            string query = "select * from Account ";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                listAccount.Add(GetAccountByDataRow(i));
            }
            return listAccount;
        }
    }
}