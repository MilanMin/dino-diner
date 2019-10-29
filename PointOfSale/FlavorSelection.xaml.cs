using System;
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private DrinkSelection drink;

        /// <summary>
        /// Constructs the flavor selection page
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructs the flavor selection page for a given drink
        /// </summary>
        /// <param name="d">The drink page that constructed the flavor selection page</param>
        public FlavorSelection(DrinkSelection d)
        {
            InitializeComponent();
            drink = d;
        }

        private void FlavorSelected(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Sodasaurus soda = (Sodasaurus)drink.drink;
            switch (button.Content)
            {
                case "Cherry":
                    soda.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.GoBack();
                    break;
                case "Chocolate":
                    soda.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.GoBack();
                    break;
                case "Cola":
                    soda.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.GoBack();
                    break;
                case "Lime":
                    soda.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.GoBack();
                    break;
                case "Orange":
                    soda.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.GoBack();
                    break;
                case "Root Beer":
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.GoBack();
                    break;
                case "Vanilla":
                    soda.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.GoBack();
                    break;
            }
        }
    }
}
