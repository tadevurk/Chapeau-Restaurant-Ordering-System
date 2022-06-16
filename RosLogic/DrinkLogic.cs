using System.Collections.Generic;
using RosModel;
using RosDAL;
using System;

namespace RosLogic
/////////////////////////// Vedat Turk 683343 IT1D ////////////////////////////////////////////
{
    public class DrinkLogic
    {
        DrinkDAO drinkDAO = new DrinkDAO();

        public void AddDrinks(List<Drink> drinkInOrderProcess, Order order)
        {
            drinkDAO.AddDrinks(drinkInOrderProcess, order);
        }

        public List<Drink> ReadContainedDrinks(Table table)
        {
            return drinkDAO.ReadContainedDrinks(table);
        }

        public List<Drink> GetAllDrinks()
        {
            return drinkDAO.GetAllDrinks();
        }
    }
}
