using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pancakes = new MenuItem("Pancakes","blueberry or buttermilk", "Breakfast", 3.99);
            MenuItem reuben = new MenuItem("Reuben","Corned beef on toasted black Rye bread with dressing", "Lunch", 5.25);
            MenuItem hamburger = new MenuItem("Hamburger","1/2lb ground beef cooked to order, served with fries", "Dinner", 7.99);
            MenuItem beer = new MenuItem("Beer","Ask waitress for draft list", "Beverages", 3.99);
            List <MenuItem> newMenu = new List<MenuItem>();
            newMenu.Add(hamburger);
            newMenu.Add(reuben);
            newMenu.Add(pancakes);
            newMenu.Add(beer);
            
            Menu myRestaurantMenu = new Menu(newMenu);
            //myRestaurantMenu.PrintMenu();

            //myRestaurantMenu.PrintMenuItem();
            myRestaurantMenu.AddMenuItem();
            myRestaurantMenu.PrintMenu();
            //myRestaurantMenu.DeleteMenuItem();
            //myRestaurantMenu.PrintMenu();
            
            //Console.WriteLine(pancakes.description);
            
        }
    }
}
