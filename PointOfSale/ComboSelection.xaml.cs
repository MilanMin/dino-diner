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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructs the comboselection page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when an entree is selected
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        private void EntreeSelected(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
