using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Brontowurst.
    /// </summary>
    public class Brontowurst : Entree
    {

        /// <summary>
        /// Holds whether or not there should be a bun.
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Holds whether or not there should be peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Holds whether or not there should be onions.
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// Provides the list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a Brontowurst.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        /// <summary>
        /// Holds the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        
        /// <summary>
        /// Holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
