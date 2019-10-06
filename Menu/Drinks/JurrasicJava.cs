using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Contains the class for the drink JurrassicJava.
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Variable for whether or not there should be room for cream in the drink.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Variable for whether or not the drink should be decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Creates a jurrasic java drink.
        /// </summary>
        public JurrasicJava()
        {
            Size = Size.Small;
            Ice = false;
        }

        /// <summary>
        /// Contains the size of the drink.
        /// </summary>
        private Size size;

        /// <summary>
        /// Contains the get and set accessor for the size of the drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Contains the get accessor for the ingredients list of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// Method that leaves room for cream when called.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Method that adds ice to the drink when called.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
