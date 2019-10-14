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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Stores the text for the side button
        /// </summary>
        private string side = "PICK SIDE";
        /// <summary>
        /// Stores the public get and set accessors for the side button
        /// </summary>
        public string Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                CustomizeComboSideButton.Content = value;
            }
        }

        /// <summary>
        /// Stores the text for the drink button
        /// </summary>
        private string drink = "PICK DRINK";
        /// <summary>
        /// Stores the public get and set accessors for the side button
        /// </summary>
        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                CustomizeComboDrinkButton.Content = value;
            }
        }

        /// <summary>
        /// Constructs the customizecombo page
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when side is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(this));
        }

        /// <summary>
        /// Runs when drink is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(this));
        }
    }
}
