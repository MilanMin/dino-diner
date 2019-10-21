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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
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
                    order.Items.Add(new Fryceritops());
                    break;
                case "Meteor Mac & Cheese":
                    order.Items.Add(new MeteorMacAndCheese());
                    break;
                case "Mezzorella Sticks":
                    order.Items.Add(new MezzorellaSticks());
                    break;
                case "Triceritots":
                    order.Items.Add(new Triceritots());
                    break;
            }

            DisableAllSideButtons();
            
        }

        private void DisableAllSideButtons()
        {
            BtnFryceritops.IsEnabled = false;
            BtnMeteorMacAndCheese.IsEnabled = false;
            BtnMezzorellaSticks.IsEnabled = false;
            BtnTriceritots.IsEnabled = false;
        }
    }
}
