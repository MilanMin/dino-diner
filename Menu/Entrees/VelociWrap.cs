using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the VelociWrap.
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Holds whether or not there should be dressing.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Holds whether or not there should be lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Holds whether or not there should be cheese.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Provides a list of ingredients for the VelociWrap.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Breast" };
                ingredients.Add("Flour Tortilla");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a VelociWrap.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds the dressing.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds the cheese.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
