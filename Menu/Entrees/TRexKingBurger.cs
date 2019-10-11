using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the TRexKingBurger.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Holds whether or not there should be a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Holds whether or not there should be lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Holds whether or not there should be tomato.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Holds whether or not there should be onion.
        /// </summary>
        private bool onion = true;
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
        /// Holds whether or not there should be mayo.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Provides a list of ingredients for the TRexKingBurger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a TRexKingBurger.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Holds the tomato.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
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
        /// Holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
