using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Contains the class for the drink Tyrannotea.
    /// </summary>
    public class Tyrannotea : Drink
    {

        /// <summary>
        /// Contains the variable of whether or not the drink is sweet.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Contains the variable of whether or not the drink has a lemon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Constructor for Tyrannotea.
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Contains the size of the drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Contains the get and set acessor for the drink's size.
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
                uint multiplier = 1;
                if (Sweet)
                {
                    multiplier = 2;
                }
                switch (value)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8 * multiplier;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16 * multiplier;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32 * multiplier;
                        break;
                }
            }
        }

        /// <summary>
        /// Contains the get accessor for the list of the drink's ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
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

            if (Sweet)
            {
                sb.Append("Sweet ");
            }

            sb.Append("Tyrannotea");
            return sb.ToString();
        }
    }
}
