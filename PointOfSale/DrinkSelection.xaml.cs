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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Stores the combo page that constructed this drink selection page (if applicable)
        /// </summary>
        private CustomizeCombo c;

        /// <summary>
        /// Stores the drink that is associated with this class.
        /// </summary>
        public Drink drink;

        /// <summary>
        /// Constructs the drink selection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink d)
        {
            InitializeComponent();
            drink = d;
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
                    tryAddDrink(new Sodasaurus());
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Hidden;

                    FlavorButton.Content = "Flavor";
                    IceButton.Content = "Hold Ice";
                    disableAllDrinkButtons();
                    break;
                case "Tyrannotea":
                    tryAddDrink(new Tyrannotea());
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Visible;

                    FlavorButton.Content = "Sweet";
                    IceButton.Content = "Hold Ice";
                    disableAllDrinkButtons();
                    break;
                case "Jurrasic Java":
                    tryAddDrink(new JurassicJava());
                    FlavorButton.Visibility = Visibility.Visible;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Hidden;

                    FlavorButton.Content = "Decaf";
                    IceButton.Content = "Add Ice";
                    disableAllDrinkButtons();
                    break;
                case "Water":
                    tryAddDrink(new Water());
                    FlavorButton.Visibility = Visibility.Hidden;
                    IceButton.Visibility = Visibility.Visible;
                    LemonButton.Visibility = Visibility.Visible;
                    IceButton.Content = "Hold Ice";
                    disableAllDrinkButtons();
                    break;
            }
        }

        private void disableAllDrinkButtons()
        {
            SodasaurusBtn.IsEnabled = false;
            JurrasicJavaBtn.IsEnabled = false;
            TyrannoteaBtn.IsEnabled = false;
            WaterBtn.IsEnabled = false;
        }

        private void tryAddDrink(Drink d)
        {
            if (drink == null)
            {
                Order order = (Order)DataContext;
                drink = d;
                order.Add(drink);
            }
            else
            {
                Order order = (Order)DataContext;
                order.Remove(drink);
                drink = d;
                order.Add(drink);
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
            else if ((string)b.Content == "Sweet")
            {
                if(drink is Tyrannotea tea)
                {
                    tea.Sweet = true;
                }
            }
            else if ((string)b.Content == "Decaf")
            {
                if(drink is JurassicJava java)
                {
                    java.Decaf = true;
                }
            }
            
        }

        /// <summary>
        /// Runs when lemon is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void ToggleLemon(object sender, RoutedEventArgs e)
        {
            if(drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            else if (drink is Water water)
            {
                water.AddLemon();
            }
        }

        /// <summary>
        /// Runs when Ice is clicked
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void ToggleIce(object sender, RoutedEventArgs e)
        {
            if(drink is JurassicJava java)
            {
                java.AddIce();
            }
            else
            {
                drink.HoldIce();
            }
            
        }

        private void OnSmallChecked(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Small;
        }

        private void OnMediumChecked(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Medium;
        }

        private void OnLargeChecked(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Large;
        }

        private void OnClickDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
