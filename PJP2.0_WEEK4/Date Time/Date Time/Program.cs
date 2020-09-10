using System;
using System.Linq;

namespace Date_Time_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = MakeMenu();
            
            Console.WriteLine("Select one of the following options: ");
           
            menu.DisplayMenu();
            var choice = menu.GetUsersChoice();
            if (choice > 5)
                throw new InvalidOptionException("The option entered is invalid... ");
            foreach (var menuItem in menu.MenuItems.Where(menuItem => choice == menuItem.MenuItemId))
            {
                menuItem.SubMenu.DisplayOptionsAndGetValues();
                menuItem.SubMenu.OperationToPerform.PerformOperation();
                menuItem.SubMenu.OperationToPerform.DisplayResult();
            }
        }

       
    }
}
