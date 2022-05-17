using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Bill
    {
        public int BillNumber { get; set; }
        public decimal BillAmount { get; set; }
        public bool BillStatus { get; set; }
        public decimal TipAmount { get; set; }
        public string Feedback { get; set; }
        public DateTime PaymentDate { get; set; }

        public int TableNumber { get; set; }
    }
}
