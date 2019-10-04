using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
    }
}
