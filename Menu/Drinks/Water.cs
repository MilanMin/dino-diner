using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the drink water.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Variable that holds whether or not a lemon comes with the drink.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Constructor for the drink water.
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Price = .1;
            Calories = 0;
        }

        /// <summary>
        /// Variable that holds the size of the drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Contains the get and set accessor for the drink water.
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
            }
        }

        /// <summary>
        /// Contains the get accessor for the list of ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Method that adds a lemon to the drink.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
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

            sb.Append("Water");
            return sb.ToString();
        }
    }
}
