using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;

        public Water()
        {
            Size = Size.Small;
            Price = .1;
            Calories = 0;
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
                return ingredients;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
