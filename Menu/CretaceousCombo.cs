﻿/* CretaceousCombo.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for a combo.
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem
    {

        /// <summary>
        /// The entree in the combo.
        /// </summary>
        public Entree Entree { get; set; }
        private Drink drink;
        /// <summary>
        /// The drink in the combo.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                drink.PropertyChanged += this.PropertyChanged;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }

        private Side side;
        /// <summary>
        /// The side in the combo.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.PropertyChanged += this.PropertyChanged;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Constructor for the combo.
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// The size of the combo.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// The PropertyChanged Event Handler; Notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// The public getter for the size of the combo.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                Drink.Size = size;
                Side.Size = size;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }
        /// <summary>
        /// The public getter for the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - .25;
            }
        }

        /// <summary>
        /// The public getter for the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Drink.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// The public getter for the ingredients in the combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Returns "Combo".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        /// <summary>
        /// Gets the description for the combo.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special preperation instructions.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.ToString());
                special.AddRange(Side.Special);
                special.Add(Drink.ToString());
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

    }
}
