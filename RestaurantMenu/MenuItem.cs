using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }


        private double price;

        public double Price
        {
            get { return price; }
            set { 
                if (value > 0)
                {
                    price = value;
                } 
                else 
                { 
                    price = 0;
                }
                
            }
        }
        public string dateAdded = DateTime.Today.ToString("MMMM dd");
        public MenuItem(string Name, string description, string category, double price)
        {
            this.Name = Name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
            
        }

    }

    
}
