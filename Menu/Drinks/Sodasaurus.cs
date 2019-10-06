using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for the Sodasaurus drink.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Contains the flavor for the sodasaurus drink.
        /// </summary>
        public SodasaurusFlavor Flavor;

        /// <summary>
        /// Creates a sodasaurus.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Contains the size of the drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Contains the get and set accessor for the size of the drink.
        /// </summary>
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
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Contains the get accessor for the ingredients list of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
    }
}
