using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class DTItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal SellPrice { get; set; }
        public decimal InitialPrice { get; set; }
        public byte[] Picture { get; set; }
        public int Warranty { get; set; }
        public string BrandName { get; set; }
    }
}
