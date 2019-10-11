using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for a PrehistoricPBJ.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Holds whether or not there should be peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Holds whether or not there should be jelly.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Provides a list of ingredients for the Prehistoric PBJ.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a PrehistoricPBJ.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Holds the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Holds the jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
