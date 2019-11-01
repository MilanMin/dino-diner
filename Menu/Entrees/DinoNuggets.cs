/* DinoNuggets.cs
 * Author: Milan Minocha
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for DinoNuggets.
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// The PropertyChanged Event Handler; Notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets the description of the item.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special preparation instructions for this item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (numNuggets > 6)
                {
                    special.Add($"{numNuggets - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Holds the amount of nuggets.
        /// </summary>
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
