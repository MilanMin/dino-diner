using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for a combo.
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// The entree in the combo.
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// The drink in the combo.
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// The side in the combo.
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Constructor for the combo.
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// The size of the combo.
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// The public getter for the size of the combo.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                Drink.Size = size;
                Side.Size = size;
            }
        }
        /// <summary>
        /// The public getter for the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - .25;
            }
        }

        /// <summary>
        /// The public getter for the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Drink.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// The public getter for the ingredients in the combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Provides the name of the entree in the combo that was chosen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Entree.GetType() == new Brontowurst().GetType())
            {
                sb.Append("Brontowurst ");
            }
            else if (Entree.GetType() == new DinoNuggets().GetType())
            {
                sb.Append("Dino-Nuggets ");
            }
            else if (Entree.GetType() == new PrehistoricPBJ().GetType())
            {
                sb.Append("Prehistoric PB&J ");
            }
            else if (Entree.GetType() == new PterodactylWings().GetType())
            {
                sb.Append("Pterodactyl Wings ");
            }
            else if (Entree.GetType() == new SteakosaurusBurger().GetType())
            {
                sb.Append("Steakosaurus Burger ");
            }
            else if (Entree.GetType() == new TRexKingBurger().GetType())
            {
                sb.Append("T-Rex King Burger ");
            }
            else if (Entree.GetType() == new VelociWrap().GetType())
            {
                sb.Append("Veloci-Wrap ");
            }

            sb.Append("Combo");
            return sb.ToString();
        }

    }
}
