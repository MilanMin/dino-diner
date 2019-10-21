/* VelociWrapTest.cs
 * Author: Nathan Bean
 * Edited by: Milan Minocha
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void SpecialShouldHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            string[] special = vw.Special;
            Assert.Contains("Hold Dressing", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            string[] special = vw.Special;
            Assert.Contains("Hold Lettuce", special);
            Assert.Equal<int>(1, special.Length);
        }
        [Fact]
        public void SpecialShouldHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            string[] special = vw.Special;
            Assert.Contains("Hold Cheese", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldHoldDressingAndLettuceAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            string[] special = vw.Special;
            Assert.Contains("Hold Dressing", special);
            Assert.Contains("Hold Lettuce", special);
            Assert.Contains("Hold Cheese", special);
            Assert.Equal<int>(3, special.Length);
        }

        [Fact]
        public void HoldingShouldNotifyOfSpecialAndIngredientsPropertyChanged()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldDressing();
            });
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldLettuce();
            });
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldCheese();
            });
        }
    }
}
