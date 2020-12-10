using System;
using System.Collections.Generic;

namespace studio4_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MenuItem newItem1 = new MenuItem(4.99, "Garlic linguine", "Dinner", true);
            MenuItem newItem2 = new MenuItem(6.99, "Really good steak", "Dinner", false);
            MenuItem newItem3 = new MenuItem(2.99, "Delicious wings", "Appetizer", true);

            DateTime today = DateTime.Now;
            List<MenuItem> startingMenu = new List<MenuItem>();

            Menu ourMenu = new Menu(today, startingMenu);

            ourMenu.AddItem(newItem1);
            ourMenu.AddItem(newItem2);
            ourMenu.AddItem(newItem3);

            ourMenu.PrintMenu();

            ourMenu.PrintItem(newItem2);

            ourMenu.RemoveItem(newItem2);

            ourMenu.PrintMenu();

        }
    }
}
