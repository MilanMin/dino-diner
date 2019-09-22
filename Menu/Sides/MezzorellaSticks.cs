using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class MezzorellaSticks : Side
    {
        

        public MezzorellaSticks()
        {
            this.Price = .99;
            this.Calories = 540;
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Breading");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;
        }
    }
}
