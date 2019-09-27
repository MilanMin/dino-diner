using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {

        public bool Sweet { get; set; } = false;
        public bool Lemon { get; set; } = false;

        public Tyrannotea()
        {
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

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
