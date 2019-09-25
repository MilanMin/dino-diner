using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        public double Price { get; set; }
        public abstract Size Size { get; set; }
    }
}
