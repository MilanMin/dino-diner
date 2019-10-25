/* Order.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents a customer's order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Contains all the items in the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Contains the Subtotal cost for the order.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach(IOrderItem i in Items)
                {
                    cost += i.Price;
                }
                if (cost < 0) cost = 0;
                return cost;
            }
        }

        /// <summary>
        /// Contains the sales tax rate for the order.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .065;

        /// <summary>
        /// Contains the sales tax cost for the order.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// Contains the total cost for the order.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }

        /// <summary>
        /// An event handler for property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
