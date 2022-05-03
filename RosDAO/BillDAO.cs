using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class BillDAO : BaseDAO
    {
        public Bill GetBillById(int id)
        {
            return new Bill();
        }

        public List<Bill> GetAllBills()
        {
            return new List<Bill>();
        }
    }
}
