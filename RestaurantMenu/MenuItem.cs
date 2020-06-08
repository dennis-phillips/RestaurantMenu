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
        public string dateAdded = DateTime.Now.ToString("MMMM dd h:mm tt");
        public MenuItem(string Name, string description, string category, double price)
        {
            this.Name = Name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
            
        }

        
        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem s = toBeCompared as MenuItem;
            return s.Name == Name;
        }

    }   
        

    
}
