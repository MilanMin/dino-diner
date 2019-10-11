using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Size)
            {
                case Size.Small:
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
            }

            switch (Flavor)
            {
                case SodasaurusFlavor.Cola:
                    sb.Append("Cola ");
                    break;
                case SodasaurusFlavor.RootBeer:
                    sb.Append("RootBeer ");
                    break;
                case SodasaurusFlavor.Cherry:
                    sb.Append("Cherry ");
                    break;
                case SodasaurusFlavor.Vanilla:
                    sb.Append("Vanilla ");
                    break;
                case SodasaurusFlavor.Chocolate:
                    sb.Append("Chocolate ");
                    break;
                case SodasaurusFlavor.Orange:
                    sb.Append("Orange ");
                    break;
                case SodasaurusFlavor.Lime:
                    sb.Append("Lime ");
                    break;
            }

            sb.Append("Sodasaurus");
            return sb.ToString();
        }
    }
}
