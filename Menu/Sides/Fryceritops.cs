using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for Fryceritops.
    /// </summary>
    public class Fryceritops : Side
    {

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
    }
}
