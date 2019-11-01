﻿/* MeteorMacAndCheese.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for MeteorMacAndCheese.
    /// </summary>
    public class MeteorMacAndCheese : Side, INotifyPropertyChanged
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
                return special.ToArray();
            }
        }
        /// <summary>
        /// Holds the size.
        /// </summary>
        protected Size size;

        /// <summary>
        /// Constructs MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Provides a list of ingredients for MeteorMacAndCheese.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or Sets the Size.
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
                switch (size)
                {
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 420;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                }
            }
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

            sb.Append("Meteor Mac and Cheese");
            return sb.ToString();
        }
    }
}
