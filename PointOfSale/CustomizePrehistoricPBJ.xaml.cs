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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Holds the entree from which this PB&J belongs to.
        /// </summary>
        private PrehistoricPBJ entree;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pbj">The PB&J that this class should customize.</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            entree = pbj;
        }

        /// <summary>
        /// Holds the jelly.
        /// </summary>
        /// <param name="sender">Hold Jelly button</param>
        /// <param name="e">Arguments</param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            entree.HoldJelly();
        }

        /// <summary>
        /// Holds the peanut butter
        /// </summary>
        /// <param name="sender">Hold Peanut Butter button</param>
        /// <param name="e">Arguments</param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            entree.HoldPeanutButter();
        }

        /// <summary>
        /// Navigates to either the menu category selection page or the combo being created (if applicable)
        /// </summary>
        /// <param name="sender">The OnDone button.</param>
        /// <param name="e">Arguments</param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
