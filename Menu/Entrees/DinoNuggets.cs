﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {

        private uint numNuggets = 6;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i=0; i<numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25+.25*(numNuggets-6);
            this.Calories = 59*numNuggets;
        }

        public void AddNugget()
        {
            this.numNuggets++;
            this.Price = 4.25 + .25 * (numNuggets - 6);
            this.Calories = 59 * numNuggets;
        }
    }
}
