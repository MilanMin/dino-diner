/* Drink.cs
 * Author: Milan Minocha
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Contains the base class for a Drink.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem
    {

        /// <summary>
        /// Gets the description for the item.
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Gets the special preperation instructions for the item.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Contains the price of a drink.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Contains the calories for a drink.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Contains the ingredients for a drink.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Contains the size for a drink.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Contains whether there should be ice or not in a drink.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Holds the ice in a drink.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
