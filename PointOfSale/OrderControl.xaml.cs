﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        
        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ListBox)sender).SelectedItem is Side side)
            {

                NavigationService?.Navigate(new SideSelection(side));
            }
            if (((ListBox)sender).SelectedItem is Entree entree)
            {

                NavigationService?.Navigate(new EntreeSelection(entree));
            }
            if (((ListBox)sender).SelectedItem is Drink drink)
            {

                NavigationService?.Navigate(new DrinkSelection(drink));
            }

        }

        /*
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }

        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }
        */

        

        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                if(element.DataContext is IOrderItem item)
                {
                    order.Remove(item);
                }
            }
            
        }
    }
}
