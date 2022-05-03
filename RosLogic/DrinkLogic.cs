using System;
using System.Collections.Generic;
using RosModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosDAL;

namespace RosLogic
{
    public class DrinkLogic
    {
        DrinkDAO drinkDAO = new DrinkDAO();
        public Drink GetDrinkById(int id)
        {
            return drinkDAO.GetDrinkById(id);
        }

        public List<Drink> GetAllDrink()
        {
            return drinkDAO.GetAllDrink();
        }

        public Drink GetDrinkByType(string type)
        {
            return drinkDAO.GetDrinkByType(type);
        }
    }
}
