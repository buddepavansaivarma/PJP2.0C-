using System;
using System.Collections.Generic;

namespace Date_Time_Calculator
{
    public class Menu 
    {
       

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public void DisplayMenu()
        {
            foreach (var menuItem in MenuItems)
                menuItem.DisplayOption();

        }
        public int GetUsersChoice()
        {
            Console.WriteLine("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}