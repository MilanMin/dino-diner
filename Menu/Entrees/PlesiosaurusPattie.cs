using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Plesiosaurus Pattie
    /// </summary>
    public class PlesiosaurusPattie : Entree
    {
        /// <summary>
        /// Keeps track of whether or not there is a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Keeps track of whether or not there is mayo.
        /// </summary>
        private bool mayo = true;
        
        /// <summary>
        /// Constructs a Plesiosaurus Pattie.
        /// </summary>
        public PlesiosaurusPattie()
        {
            Price = 5.50;
            Calories = 487;
        }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Fish Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (mayo) ingredients.Add("Mayonaise");
                return ingredients;
            }
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void Holdbun()
        {
            bun = false;
        }

        /// <summary>
        /// Holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
    }
}
