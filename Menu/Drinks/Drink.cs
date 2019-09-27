using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public abstract List<string> Ingredients { get; }
        public abstract Size Size { get; set; }
        public bool Ice { get; set; } = true;
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
