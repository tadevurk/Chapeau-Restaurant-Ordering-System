using RosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosDAL
{
    public class DrinkDAO : BaseDAO
    {
        public Drink GetDrinkById(int id)
        {
            return new Drink();
        }

        public List<Drink> GetAllDrink()
        {
            return new List<Drink>();
        }

        public Drink GetDrinkByType(string type)
        {
            return new Drink();
        }
    }
}
