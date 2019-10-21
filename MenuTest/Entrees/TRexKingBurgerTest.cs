/* TRexKingBurger.cs
 * Author: Nathan Bean
 * Edited by: Milan Minocha
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            string[] special = trex.Special;
            Assert.Contains("Hold Bun", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            string[] special = trex.Special;
            Assert.Contains("Hold Pickles", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            string[] special = trex.Special;
            Assert.Contains("Hold Ketchup", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            string[] special = trex.Special;
            Assert.Contains("Hold Lettuce", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            string[] special = trex.Special;
            Assert.Contains("Hold Tomato", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            string[] special = trex.Special;
            Assert.Contains("Hold Mustard", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            string[] special = trex.Special;
            Assert.Contains("Hold Mayo", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldHoldBunAndPickleAndKetchupAndLettuceAndTomatoAndMustardAndMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldMustard();
            trex.HoldMayo();
            string[] special = trex.Special;
            Assert.Contains("Hold Bun", special);
            Assert.Contains("Hold Pickles", special);
            Assert.Contains("Hold Ketchup", special);
            Assert.Contains("Hold Lettuce", special);
            Assert.Contains("Hold Tomato", special);
            Assert.Contains("Hold Mustard", special);
            Assert.Contains("Hold Mayo", special);
            Assert.Equal<int>(7, special.Length);
        }

        [Fact]
        public void HoldingShouldNotifyOfSpecialAndIngredientsPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldBun();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldPickle();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldKetchup();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldLettuce();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldTomato();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldMustard();
            });
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
            Assert.PropertyChanged(trex, "Ingredients", () =>
            {
                trex.HoldMayo();
            });
        }

    }

}
