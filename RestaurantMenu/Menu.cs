using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        

        public List <MenuItem> adjustableMenu { get; set; }

        public Menu(List<MenuItem> adjustableMenu)
        {
            this.adjustableMenu = adjustableMenu;
        }
        public void PrintMenu()
        {
            foreach (MenuItem item in adjustableMenu)
            {
                Console.WriteLine(item.Category + "\n*******\n" + item.Name + ":" + item.Description + "\n*" + item.Price + "\nDate added:" + item.dateAdded);
            }
        }
    }
    
}

