using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public abstract class Item
    {
        int ItemID { get; set; }
        string ItemName { get; set; }
        string ItemPrice { get; set; }
        int ItemStock { get; set; }
        string ItemStatus { get; set; }
        string ItemType { get; set; }
    }
}
