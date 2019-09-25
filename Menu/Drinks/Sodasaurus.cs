using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor Flavor;

        public Sodasaurus()
        {
            Price = 1.50;
            Size = Size.Small;
        }

        public Size size;
        public override Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        break;
                }
            }
        }
    }
}
