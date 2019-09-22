using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for Triceritots.
    /// </summary>
    public class Triceritots : Side
    {

        protected Size size;

        /// <summary>
        /// Constructs Triceritots.
        /// </summary>
        public Triceritots()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Provides a list of ingredients for Triceritots.
        /// </summary>
        public override List<string> Ingredients
        {
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
        public override Size Size
        {
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
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                }
            }
        }
    }
}
