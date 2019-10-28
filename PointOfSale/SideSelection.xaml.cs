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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side Side;

        private CustomizeCombo c = null;
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(CustomizeCombo C)
        {
            InitializeComponent();
            c = C;
        }

        public SideSelection(Side s)
        {
            InitializeComponent();
            Side = s;
        }

        private void SideChosen(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (c!= null){
                c.Side = (string)b.Content;
            }
            Order order = (Order)DataContext;
            switch ((string)b.Content)
            {
                case "Fryceritops":
                    TryAddSide(new Fryceritops());
                    break;
                case "Meteor Mac & Cheese":
                    TryAddSide(new MeteorMacAndCheese());
                    break;
                case "Mezzorella Sticks":
                    TryAddSide(new MezzorellaSticks());
                    break;
                case "Triceritots":
                    TryAddSide(new Triceritots());
                    break;
            }

            DisableAllSideButtons();
            
        }

        private void TryAddSide(Side s)
        {

            if (Side == null)
            {
                Order order = (Order)DataContext;
                Side = s;
                order.Items.Add(Side);
            }
            else
            {
                //Add code
            }
            EnableSizeButtons();
        }

        private void EnableSizeButtons()
        {
            SizeSmall.IsEnabled = true;
            SizeMedium.IsEnabled = true;
            SizeLarge.IsEnabled = true;
        }

        private void DisableAllSideButtons()
        {
            BtnFryceritops.IsEnabled = false;
            BtnMeteorMacAndCheese.IsEnabled = false;
            BtnMezzorellaSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
        }

        private void SizeSmall_Checked(object sender, RoutedEventArgs e)
        {
            Side.Size = DinoDiner.Menu.Size.Small;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SizeMedium_Checked(object sender, RoutedEventArgs e)
        {
            Side.Size = DinoDiner.Menu.Size.Medium;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SizeLarge_Checked(object sender, RoutedEventArgs e)
        {
            Side.Size = DinoDiner.Menu.Size.Large;
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
