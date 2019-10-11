using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the SteakosaurusBurger.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Holds whether or not there should be a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Holds whether or not there should be pickle.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Holds whether or not there should be ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Holds whether or not there should be mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Provides a list of ingredients for the SteakosaurusBurger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a SteakosaurusBurger.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Holds the pickle.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Holds the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Holds the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
