/* JurassicJava.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Contains the class for the drink JurrassicJava.
    /// </summary>
    public class JurassicJava : Drink, INotifyPropertyChanged
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
        /// Gets the special preparation instructions for this item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
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
        /// Variable for whether or not there should be room for cream in the drink.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Private backing variable for Decaf.
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Variable for whether or not the drink should be decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Creates a jurrasic java drink.
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
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
                        Price = .59;
                        Calories = 2;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// Method that leaves room for cream when called.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method that adds ice to the drink when called.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns the name of the menu item.
        /// </summary>
        /// <returns>Name of the menu item.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Size)
            {
                case Size.Small:
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
            }
            if (Decaf == true)
            {
                sb.Append("Decaf ");
            }
                
            sb.Append("Jurassic Java");
            return sb.ToString();
        }

        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
