using System;
using System.Collections.Generic;

namespace studio3_solution
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
    }
}
