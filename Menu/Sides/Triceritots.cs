using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class Triceritots : Side
    {
        

        public Triceritots()
        {
            this.Price = .99;
            this.Calories = 352;
            this.Ingredients.Add("Potatoes");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;
        }
    }
}
