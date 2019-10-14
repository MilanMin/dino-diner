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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
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
        }
    }
}
