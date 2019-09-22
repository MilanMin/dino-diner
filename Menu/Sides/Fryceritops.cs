using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class Fryceritops : Side
    {
        

        public Fryceritops()
        {
            this.Calories = 222;
            this.Ingredients.Add("Potatoes");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;
        }

        public override Size Size{
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = .99;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        break;
                }
            }
        }
    }
}
