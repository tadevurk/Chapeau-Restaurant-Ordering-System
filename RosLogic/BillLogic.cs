using System;
using System.Collections.Generic;
using RosDAL;
using RosModel;

namespace RosLogic
{
    public class BillLogic
    {
        BillDAO billDAO = new BillDAO();
        
        public Bill GetBillById(int id)
        {
            return billDAO.GetBillById(id);
        }

        public List<Bill> GetAllBills()
        {
            return billDAO.GetAllBills();
        }
    }
}
