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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Stores the combo page that constructed this drink selection page (if applicable)
        /// </summary>
        private CustomizeCombo c = null;
        /*
        private bool ice;
        private bool lemon;
        private bool sweet;
        private bool decaf;
        */

        /// <summary>
        /// Constructs the drink selection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructs the drink selection page given a combo page
        /// </summary>
        /// <param name="C">The combo page that this drink selection page was constructed from</param>
        public DrinkSelection(CustomizeCombo C)
        {
            InitializeComponent();
            c = C;
        }

        /// <summary>
        /// Runs when a drink is chosen
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void DrinkChosen(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (c != null)
            {
                c.Drink = (string)b.Content;
            }
            
            switch ((string)b.Content)
            {
                case "Sodasaurus":
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Collapsed;

                    FlavorButton.Content = "Flavor";
                    break;
                case "Tyrannotea":
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Visible;

                    FlavorButton.Content = "Sweet";
                    break;
                case "Jurrasic Java":
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Visible;

                    FlavorButton.Content = "Decaf";
                    break;
                case "Water":
                    FlavorButton.Visibility = Visibility.Collapsed;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Visible;
                    break;
            }
        }

        /// <summary>
        /// Runs when flavor is selected
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if ((string)b.Content == "Flavor")
            {
                NavigationService.Navigate(new FlavorSelection(this));
            }
            
        }

        /// <summary>
        /// Runs when lemon is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void ToggleLemon(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Runs when Ice is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void ToggleIce(object sender, RoutedEventArgs e)
        {

        }
    }
}
