/* PlesiosaurusPattie.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Plesiosaurus Pattie
    /// </summary>
    public class PlesiosaurusPattie : Entree, INotifyPropertyChanged
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
                if (!bun) special.Add("Hold Bun");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        public override string ToString()
        {
            return $"Plesiosaurus Pattie";

        }

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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
