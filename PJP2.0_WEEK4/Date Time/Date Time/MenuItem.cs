using System;

namespace Date_Time_Calculator
{
    public class MenuItem : MenuItem
    {
        public string Option { get; }
        public int MenuItemId { get; }
        

        public MenuItem(string option, int menuItemId)
        {
            Option = option;
            MenuItemId = menuItemId;
            SubMenu = subMenu;
        }

        public void DisplaySubMenu()
        {
            SubMenu.DisplayOptionsAndGetValues();
        }

        public void DisplayOption()
        {
            Console.WriteLine("{0}:{1}", MenuItemId, Option);
        }
    }
}