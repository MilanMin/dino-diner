using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// The price of a menu item.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// The calories in a menu item.
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// The ingredients in a menu item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
