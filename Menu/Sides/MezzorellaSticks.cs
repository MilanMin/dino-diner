using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for MezzorellaSticks.
    /// </summary>
    public class MezzorellaSticks : Side
    {

        protected Size size;

        /// <summary>
        /// Constructs MezzorellaSticks.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Provides the list of ingredients for MezzorellaSticks.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Cheese Product");
                ingredients.Add("Breading");
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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                }
            }
        }
    }
}
