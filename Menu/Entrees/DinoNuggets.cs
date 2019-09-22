using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for DinoNuggets.
    /// </summary>
    public class DinoNuggets : Entree
    {

        private uint numNuggets = 6;

        /// <summary>
        /// Provides the list of ingredients.
        /// </summary>
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

        /// <summary>
        /// Creates DinoNuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25+.25*(numNuggets-6);
            this.Calories = 59*numNuggets;
        }

        /// <summary>
        /// Adds a Nugget.
        /// </summary>
        public void AddNugget()
        {
            this.numNuggets++;
            this.Price = 4.25 + .25 * (numNuggets - 6);
            this.Calories = 59 * numNuggets;
        }
    }
}
