/* Entree.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for entrees.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
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
        public double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// The PropertyChanged Event Handler; Notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
