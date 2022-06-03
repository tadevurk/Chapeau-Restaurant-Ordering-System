using System;
using System.Collections.Generic;
using RosModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosDAL;

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

        public List<Drink> GetAllSoftDrinks()
        {
            return drinkDAO.GetAllSoftDrinks();
        }

        public List<Drink> GetAllDrinks()
        {
            return drinkDAO.GetAllDrinks();
        }
        public List<Drink> GetAllBeers()
        {
            return drinkDAO.GetAllBeers();
        }

        public List<Drink> GetAllWines()
        {
            return drinkDAO.GetAllWines();
        }

        public List<Drink> GetAllSpirits()
        {
            return drinkDAO.GetAllSpirits();
        }

        public List<Drink> GetAllHotDrinks()
        {
            return drinkDAO.GetAllHotDrinks();
        }

        public void IncreaseDrinkStock(Drink drink)
        {
            drinkDAO.IncreaseDrinkStock(drink);
        }

        public void DecreaseDrinkStock(Drink drink)
        {
            drinkDAO.DecreaseDrinkStock(drink);
        }

        public List<Drink> WriteContainedDrinks(Table table)
        {
            return drinkDAO.WriteContainedDrinks(table);
        }
    }
}
