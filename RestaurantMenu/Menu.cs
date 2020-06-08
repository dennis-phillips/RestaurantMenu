using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {


        public List<MenuItem> AdjustableMenu { get; set; }

        public Menu(List<MenuItem> adjustableMenu)
        {
            this.AdjustableMenu = adjustableMenu;
        }

        public MenuItem CreateMenuItem()
        {
            Console.Write("Please enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter a description: ");
            string description = Console.ReadLine();
            Console.Write("Please enter a category: ");
            string category = Console.ReadLine();
            Console.Write("Please enter a price: ");
            string priceInput = Console.ReadLine();
            double price = double.Parse(priceInput);
            MenuItem newItem = new MenuItem(name, description, category, price);
            return newItem;
            
        }

        public void AddMenuItem()
        {
            Console.WriteLine("Would you like to create a menu Item? Enter 1 to create a menu item or 2 to exit: ");
            string userInput = Console.ReadLine();
            int number = Int32.Parse(userInput);
            if (number == 1)

            {
                AdjustableMenu.Add(CreateMenuItem());
                return;
            }
            else { Console.WriteLine("exiting...."); }
            
            
        }

        //public List<MenuItem> AddMenuItem ()
       // {
           // string itemName = Console.ReadLine();
            //AdjustableMenu.Add()

        //}
        
        public List<MenuItem> DeleteMenuItem()
        {
            //List<MenuItem> ModifiedMenu = AdjustableMenu;
            Console.Write("Please enter an item to Delete: ");
            string name = Console.ReadLine();
            MenuItem ItemToDelete = null;
            foreach (MenuItem item in AdjustableMenu)
            {

                
                if (name.Equals(item.Name))
                {
                    ItemToDelete = item;
                    //AdjustableMenu.Remove(item);
                }       
            }
            AdjustableMenu.Remove(ItemToDelete);
            return AdjustableMenu;
            
        }
            

        public void PrintMenu()
        {
            
            Console.WriteLine($"Menu last updated on {AdjustableMenu[AdjustableMenu.Count-1].dateAdded}");
            foreach (MenuItem item in AdjustableMenu)
            {
                Console.WriteLine(item.Category + "\n*******\n" + item.Name + ": " + item.Description + "\nPrice: " + item.Price + "\nDate added:" + item.dateAdded + "\n*******");
            }
        }
        
        public void PrintMenuItem()
        {
            Console.Write("Please enter an item to print: ");
            string name = Console.ReadLine();
            foreach (MenuItem item in AdjustableMenu)
            {
                if (name.Equals(item.Name))
                {
                    Console.WriteLine(item.Category + "\n*******\n" + item.Name + ": " + item.Description + "\nPrice: " + item.Price + "\nDate added:" + item.dateAdded + "\n*******");
                }
            }
            
        }
    }

    
}

