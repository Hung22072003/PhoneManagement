using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    internal class Account
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string DisplayName { get; set; }
        public int TypeAccount { get; set; }
    }
}
