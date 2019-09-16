using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class Fryceritops : Side
    {
        

        public Fryceritops()
        {
            this.Price = .99;
            this.Calories = 222;
            this.Ingredients.Add("Potatoes");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;
        }
    }
}
