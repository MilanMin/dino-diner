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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        /// <summary>
        /// Indicates whether this entree is for a combo.
        /// </summary>
        private bool isForComobo = false;

        /// <summary>
        /// Holds the entree from which this Entree belongs to.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="entree">The Entree that this class should customize.</param>
        public CustomizeEntree(Entree entree, bool isForComobo)
        {
            InitializeComponent();
            this.entree = entree;
            this.isForComobo = isForComobo;
            initializeButtons();
        }

        private void initializeButtons()
        {
            if (entree is Brontowurst bw)
            {
                BrontowurstHoldBun.Visibility = Visibility.Visible;
                BrontowurstHoldOnions.Visibility = Visibility.Visible;
                BrontowurstHoldPeppers.Visibility = Visibility.Visible;
            }
            else if (entree is DinoNuggets dn)
            {
                DinoNuggetsAddNugget.Visibility = Visibility.Visible;
            }
            else if (entree is PlesiosaurusPattie pp)
            {
                //TODO
            }
            else if (entree is PrehistoricPBJ pbj)
            {
                PBJHoldJelly.Visibility = Visibility.Visible;
                PBJHoldPeanutButter.Visibility = Visibility.Visible;
            }
            else if (entree is PterodactylWings pw)
            {
                //Currently no customizations available for Pterodactly Wings
            }
            else if (entree is SteakosaurusBurger sb)
            {
                SteakosaurusBurgerHoldBun.Visibility = Visibility.Visible;
                SteakosaurusBurgerHoldKetchup.Visibility = Visibility.Visible;
                SteakosaurusBurgerHoldMustard.Visibility = Visibility.Visible;
                SteakosaurusBurgerHoldPickle.Visibility = Visibility.Visible;
            }
            else if (entree is TRexKingBurger trex)
            {
                TRexKingBurgerHoldBun.Visibility = Visibility.Visible;
                TRexKingBurgerHoldKetchup.Visibility = Visibility.Visible;
                TRexKingBurgerHoldLettuce.Visibility = Visibility.Visible;
                TRexKingBurgerHoldMayo.Visibility = Visibility.Visible;
                TRexKingBurgerHoldMustard.Visibility = Visibility.Visible;
                TRexKingBurgerHoldOnion.Visibility = Visibility.Visible;
                TRexKingBurgerHoldPickle.Visibility = Visibility.Visible;
                TRexKingBurgerHoldTomato.Visibility = Visibility.Visible;
            }
            else if (entree is VelociWrap vw)
            {
                VelociWrapHoldCheese.Visibility = Visibility.Visible;
                VelociWrapHoldDressing.Visibility = Visibility.Visible;
                VelociWrapHoldLettuce.Visibility = Visibility.Visible;
            }
        }

        //PREHISTORIC PB&J CUSTOMIZATION

        /// <summary>
        /// Holds the jelly.
        /// </summary>
        /// <param name="sender">Hold Jelly button</param>
        /// <param name="e">Arguments</param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }
            
        }

        /// <summary>
        /// Holds the peanut butter
        /// </summary>
        /// <param name="sender">Hold Peanut Butter button</param>
        /// <param name="e">Arguments</param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            if(entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
            
        }

        //Brontowurst CUSTOMIZATION

        /// <summary>
        /// Holds the Bun
        /// </summary>
        /// <param name="sender">Hold Bun button</param>
        /// <param name="e">Arguments</param>
        private void OnBrontowurstHoldBun(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldBun();
            }

        }

        /// <summary>
        /// Holds the Peppers
        /// </summary>
        /// <param name="sender">Hold Peppers button</param>
        /// <param name="e">Arguments</param>
        private void OnBrontowurstHoldPeppers(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldPeppers();
            }

        }

        /// <summary>
        /// Holds the Onions
        /// </summary>
        /// <param name="sender">Hold Onions button</param>
        /// <param name="e">Arguments</param>
        private void OnBrontowurstHoldOnions(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldOnion();
            }

        }


        //Dino Nuggets CUSTOMIZATION

        /// <summary>
        /// Adds a Nugget
        /// </summary>
        /// <param name="sender">Add Nugget button</param>
        /// <param name="e">Arguments</param>
        private void OnDinoNuggetsAddNugget(object sender, RoutedEventArgs e)
        {
            if (entree is DinoNuggets dn)
            {
                dn.AddNugget();
            }

        }

        //Pterodactyl Wings CUSTOMIZATION


        //Steakosaurus Burger CUSTOMIZATION

        /// <summary>
        /// Holds the bun
        /// </summary>
        /// <param name="sender">Hold bun button</param>
        /// <param name="e">Arguments</param>
        private void OnSteakosaurusBurgerHoldBun(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldBun();
            }

        }

        /// <summary>
        /// Holds the pickle
        /// </summary>
        /// <param name="sender">Hold Pickle button</param>
        /// <param name="e">Arguments</param>
        private void OnSteakosaurusBurgerHoldPickle(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldPickle();
            }

        }

        /// <summary>
        /// Holds the ketchup
        /// </summary>
        /// <param name="sender">Hold Ketchup button</param>
        /// <param name="e">Arguments</param>
        private void OnSteakosaurusBurgerHoldKetchup(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldKetchup();
            }

        }

        /// <summary>
        /// Holds the mustard
        /// </summary>
        /// <param name="sender">Hold Mustard button</param>
        /// <param name="e">Arguments</param>
        private void OnSteakosaurusBurgerHoldMustard(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldMustard();
            }

        }


        //T-Rex King Burger CUSTOMIZATION

        /// <summary>
        /// Holds the bun
        /// </summary>
        /// <param name="sender">Hold Bun button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldBun(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldBun();
            }

        }

        /// <summary>
        /// Holds the lettuce
        /// </summary>
        /// <param name="sender">Hold Lettuce button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldLettuce(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldLettuce();
            }

        }

        /// <summary>
        /// Holds the Tomato
        /// </summary>
        /// <param name="sender">Hold Tomato button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldTomato(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldTomato();
            }

        }

        /// <summary>
        /// Holds the Onion
        /// </summary>
        /// <param name="sender">Hold Onion button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldOnion(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldOnion();
            }

        }

        /// <summary>
        /// Holds the Pickle
        /// </summary>
        /// <param name="sender">Hold Pickle button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldPickle(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldPickle();
            }

        }

        /// <summary>
        /// Holds the Ketchup
        /// </summary>
        /// <param name="sender">Hold Ketchup button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldKetchup(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldKetchup();
            }

        }

        /// <summary>
        /// Holds the mustard
        /// </summary>
        /// <param name="sender">Hold Mustard button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldMustard(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldMustard();
            }

        }

        /// <summary>
        /// Holds the Mayo
        /// </summary>
        /// <param name="sender">Hold Mayo button</param>
        /// <param name="e">Arguments</param>
        private void OnTRexKingBurgerHoldMayo(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger trex)
            {
                trex.HoldMayo();
            }

        }

        //Veloci-Wrap CUSTOMIZATION

        /// <summary>
        /// Holds the Dressing
        /// </summary>
        /// <param name="sender">Hold Dressing button</param>
        /// <param name="e">Arguments</param>
        private void OnVelociWrapHoldDressing(object sender, RoutedEventArgs e)
        {
            if (entree is VelociWrap vw)
            {
                vw.HoldDressing();
            }

        }

        /// <summary>
        /// Holds the Lettuce
        /// </summary>
        /// <param name="sender">Hold Lettuce button</param>
        /// <param name="e">Arguments</param>
        private void OnVelociWrapHoldLettuce(object sender, RoutedEventArgs e)
        {
            if (entree is VelociWrap vw)
            {
                vw.HoldLettuce();
            }

        }

        /// <summary>
        /// Holds the Cheese
        /// </summary>
        /// <param name="sender">Hold Cheese button</param>
        /// <param name="e">Arguments</param>
        private void OnVelociWrapHoldCheese(object sender, RoutedEventArgs e)
        {
            if (entree is VelociWrap vw)
            {
                vw.HoldCheese();
            }

        }



        /// <summary>
        /// Navigates to either the menu category selection page or the combo being created (if applicable)
        /// </summary>
        /// <param name="sender">The OnDone button.</param>
        /// <param name="e">Arguments</param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (isForComobo)
            {
                CustomizeCombo cc = new CustomizeCombo(entree);
                cc.DataContext = this.DataContext;
                cc.CreateCombo(entree);
                NavigationService.Navigate(cc);
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            
        }
    }
}
