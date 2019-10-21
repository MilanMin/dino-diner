/* BrontowurstTest.cs
 * Author: Nathan Bean
 * Edited by: Milan Minocha
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            string[] special = bw.Special;
            Assert.Contains<string>("Hold Bun", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            string[] special = bw.Special;
            Assert.Contains<string>("Hold Peppers", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldHoldOnions()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            string[] special = bw.Special;
            Assert.Contains<string>("Hold Onions", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldHoldBunAndPeppersAndOnions()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnion();
            string[] special = bw.Special;
            Assert.Contains<string>("Hold Bun", special);
            Assert.Contains<string>("Hold Peppers", special);
            Assert.Contains<string>("Hold Onions", special);
            Assert.Equal<int>(3, special.Length);
        }

        [Fact]
        public void HoldingShouldNotifyOfSpecialAndIngredientsPropertyChanged()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldBun();
            });
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldPeppers();
            });
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldOnion();
            });
        }
    }

}
