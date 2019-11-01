/* Side.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Contains the base class for all sides.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem
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
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The PropertyChanged Event Handler; Notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
