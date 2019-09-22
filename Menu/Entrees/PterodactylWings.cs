using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for PterodactylWings.
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Provides a list of ingredients for PterodactylWings.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs PterodactylWings.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
