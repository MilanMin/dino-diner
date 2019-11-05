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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {

        private bool isForCombo = false;

        /// <summary>
        /// Contains the entree chosen
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Constructs the entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree e)
        {
            InitializeComponent();
            entree = e;
        }

        public EntreeSelection(bool b)
        {
            InitializeComponent();
            isForCombo = true;
        }

        private void EntreeSelected(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Order order = (Order)DataContext;
                switch ((string)button.Content)
                {
                    case "Brontowurst":
                        TryAddEntree(new Brontowurst());
                        break;
                    case "Dino-Nuggets":
                        TryAddEntree(new DinoNuggets());
                        break;
                    case "Prehistoric PB&J":
                        TryAddEntree(new PrehistoricPBJ());
                        break;
                    case "Pterodactyl Wings":
                        TryAddEntree(new PterodactylWings());
                        break;
                    case "Steakosaurus Burger":
                        TryAddEntree(new SteakosaurusBurger());
                        break;
                    case "T-Rex Kingburger":
                        TryAddEntree(new TRexKingBurger());
                        break;
                    case "Veloci-Wrap":
                        TryAddEntree(new VelociWrap());
                        break;
                }
            }
        }

        private void TryAddEntree(Entree e)
        {
            if (entree == null)
            {
                Order order = (Order)DataContext;
                entree = e;
                if (!isForCombo)
                {
                    order.Add(entree);
                }
                 
            }
            else
            {
                Order order = (Order)DataContext;
                if (!isForCombo)
                {
                    order.Remove(entree);
                    
                }
                   
                entree = e;
                if (!isForCombo)
                {
                    order.Add(entree);
                }
                  
            }
            CustomizeEntree ce = new CustomizeEntree(entree, isForCombo);
            ce.DataContext = this.DataContext;
            NavigationService.Navigate(ce);

            /*
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.OrderList.OrderItems.SelectedItem = entree;

            NavigationService.Navigate(new MenuCategorySelection());
            */
        }
    }
}
