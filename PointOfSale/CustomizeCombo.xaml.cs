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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CretaceousCombo combo;

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
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            //Order order = (Order)DataContext;
            //combo = new CretaceousCombo(entree);
            //order.Add(combo);
        }

        public void CreateCombo(Entree entree)
        {
            Order order = (Order)DataContext;
            combo = new CretaceousCombo(entree);
            order.Add(combo);
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
        
        /// <summary>
        /// Runs when the small size radio button is checked.
        /// </summary>
        /// <param name="sender">The small size radio button</param>
        /// <param name="e">The event arguments</param>
        private void OnSmallChecked(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Runs when the medium size radio button is checked.
        /// </summary>
        /// <param name="sender">The medium size radio button</param>
        /// <param name="e">The event arguments</param>
        private void OnMediumChecked(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Runs when the large size radio button is checked.
        /// </summary>
        /// <param name="sender">The large size radio button</param>
        /// <param name="e">The event arguments</param>
        private void OnLargeChecked(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
