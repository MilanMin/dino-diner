using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class showing all menu items.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Provides a list of all available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.Add(new JurassicJava());
                availableMenuItems.Add(new Sodasaurus());
                availableMenuItems.Add(new Tyrannotea());
                availableMenuItems.Add(new Water());
                availableMenuItems.Add(new Brontowurst());
                availableMenuItems.Add(new DinoNuggets());
                availableMenuItems.Add(new PrehistoricPBJ());
                availableMenuItems.Add(new PterodactylWings());
                availableMenuItems.Add(new SteakosaurusBurger());
                availableMenuItems.Add(new TRexKingBurger());
                availableMenuItems.Add(new VelociWrap());
                availableMenuItems.Add(new Fryceritops());
                availableMenuItems.Add(new MeteorMacAndCheese());
                availableMenuItems.Add(new MezzorellaSticks());
                availableMenuItems.Add(new Triceritots());

                return availableMenuItems;

            }
        }

        /// <summary>
        /// Provides a list of all available entrees.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.Add(new Brontowurst());
                availableMenuItems.Add(new DinoNuggets());
                availableMenuItems.Add(new PrehistoricPBJ());
                availableMenuItems.Add(new PterodactylWings());
                availableMenuItems.Add(new SteakosaurusBurger());
                availableMenuItems.Add(new TRexKingBurger());
                availableMenuItems.Add(new VelociWrap());

                return availableMenuItems;

            }
        }

        /// <summary>
        /// Provides a list of all available sides.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.Add(new Fryceritops());
                availableMenuItems.Add(new MeteorMacAndCheese());
                availableMenuItems.Add(new MezzorellaSticks());
                availableMenuItems.Add(new Triceritots());

                return availableMenuItems;

            }
        }

        /// <summary>
        /// Provides a list of all available drinks.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.Add(new JurassicJava());
                availableMenuItems.Add(new Sodasaurus());
                availableMenuItems.Add(new Tyrannotea());
                availableMenuItems.Add(new Water());

                return availableMenuItems;

            }
        }

        /// <summary>
        /// Provides a list of all available combos.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                availableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                availableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                availableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                availableMenuItems.Add(new CretaceousCombo(new VelociWrap()));

                return availableMenuItems;

            }
        }

        /// <summary>
        /// Provides the name of the item.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
