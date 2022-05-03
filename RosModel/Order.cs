using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosModel
{
    public class Order
    {
        int OrderID { get; set; }
        DateTime DateTime { get; set; }

        string Comment { get; set; }

        List<Dish> dishes;
        List<Drink> drinks;

        public Order()
        {
            dishes = new List<Dish>();
            drinks = new List<Drink>();
            DateTime = DateTime.Now;
        }

        void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        void AddDrink(Drink drink)
        {
            drinks.Add(drink);
        }

        void AddComment(string comment)
        {
            Comment = comment;
        }

        void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        void RemoveDrink(Drink drink)
        {
            drinks.Remove(drink);
        }


    }
}
