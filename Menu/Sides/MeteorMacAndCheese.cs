using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public class MeteorMacAndCheese : Side
    {
        

        public MeteorMacAndCheese()
        {
            this.Price = .99;
            this.Calories = 420;
            this.Ingredients.Add("Macaroni Noodles");
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Pork Sausage");
            this.Size = Size.Small;
        }
    }
}
