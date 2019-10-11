using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Fryceritops.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Holds the size.
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// Provides a list of ingredients for Fryceritops.
        /// </summary>
        public override List<string> Ingredients {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or Sets the Size.
        /// </summary>
        public override Size Size{
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructs Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Friceritops";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Friceritops";
            }
            else if (Size == Size.Large)
            {
                return "Large Friceritops";
            }
            return ("Friceritops");
        }
    }
}
