
namespace RosModel
{
    public abstract class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemStock { get; set; }

        public string ItemNote { get; set; }  

        public int ItemAmount { get; set; }

        public int ItemVat { get; set; }

        public decimal SubPrice { get; set; }

        public int NoteAmount { get; set; }

    }
}
