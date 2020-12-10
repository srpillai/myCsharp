using System;
using System.Collections.Generic;

namespace studio4_solution
{
    public class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime dateUpdated, List<MenuItem> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
        }

        public List<MenuItem> AddItem(MenuItem item)
        {
            Items.Add(item);
            return Items;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {
            int toBeRemoved = -1;
            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].Equals(item))
                {
                    toBeRemoved = i;
                }
            }

            Items.RemoveAt(toBeRemoved);
            return Items;
        }

        public string MenuUpdated()
        {
            return ("The menu was last updated on " + LastUpdated);
        }

        public void PrintItem(MenuItem item)
        {
            Console.WriteLine(item.Description);
        }

        public void PrintMenu()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(Items[i].Description);
            }
        }


    }
}
