/* Sodasaurus.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Sodasaurus drink.
    /// </summary>
    public class Sodasaurus : Drink, INotifyPropertyChanged
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
        /// Private backing variable for Flavor.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Contains the flavor for the sodasaurus drink.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Creates a sodasaurus.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Contains the size of the drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Contains the get and set accessor for the size of the drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                }
            }
        }

        /// <summary>
        /// Contains the get accessor for the ingredients list of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets a description of this order item.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special instructions for this order item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }

        /// <summary>
        /// Holds the ice in a drink.
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
