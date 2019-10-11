using System.Collections.Generic;

namespace DinoDiner.Menu
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

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
