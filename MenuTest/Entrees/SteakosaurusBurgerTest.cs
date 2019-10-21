/* SteakosaurusBurger.cs
 * Author: Nathan Bean
 * Edited by: Milan Minocha
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            string[] special = sb.Special;
            Assert.Contains("Hold Bun", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldPickles()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            string[] special = sb.Special;
            Assert.Contains("Hold Pickles", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            string[] special = sb.Special;
            Assert.Contains("Hold Ketchup", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            string[] special = sb.Special;
            Assert.Contains("Hold Mustard", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldBunAndPicklesAndKetchupAndMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldPickle();
            sb.HoldKetchup();
            sb.HoldMustard();
            string[] special = sb.Special;
            Assert.Contains("Hold Bun", special);
            Assert.Contains("Hold Pickles", special);
            Assert.Contains("Hold Ketchup", special);
            Assert.Contains("Hold Mustard", special);
            Assert.Equal<int>(4, special.Length);
        }

        [Fact]
        public void HoldingShouldNotifyOfSpecialAndIngredientsPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldBun();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldPickle();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldKetchup();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldMustard();
            });
        }
    }

}
