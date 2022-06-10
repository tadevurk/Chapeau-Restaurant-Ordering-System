
namespace RosModel
{
    public class Bill
    {
        public int BillNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TipAmount { get; set; }
        public string Feedback { get; set; }
        public string PaymentMethod { get; set; }

        public int TableNumber { get; set; }
    }
}
