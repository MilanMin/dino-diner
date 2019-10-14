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
            
        }
    }
}
