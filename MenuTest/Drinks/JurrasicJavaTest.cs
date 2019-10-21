/* JurrasicJavaTest.cs
 * Author: Milan Minocha
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(false, java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(false, java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Equal(true, java.Ice);
        }

        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Equal(true, java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            string[] special = java.Special;
            Assert.Contains<string>("Leave Room For Cream", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            string[] special = java.Special;
            Assert.Contains<string>("Add Ice", special);
            Assert.Equal<int>(1, special.Length);
        }

        [Fact]
        public void SpecialShouldAddIceAndLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            string[] special = java.Special;
            Assert.Contains<string>("Add Ice", special);
            Assert.Contains<string>("Leave Room For Cream", special);
            Assert.Equal<int>(2, special.Length);
        }

        [Fact]
        public void ChangingSizeShouldNotifyOfDescriptionAndPricePropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Small;
            });
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Small;
            });
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Medium;
            });
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
            });
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Large;
            });
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifyOfSpecialPropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }
    }
}
