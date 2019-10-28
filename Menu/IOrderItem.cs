/* IOrderItem.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents an order item.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Holds the price of the item.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Holds the description of the item.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Holds the special instructions for prepreation of the item.
        /// </summary>
        string[] Special { get; }
    }
}
