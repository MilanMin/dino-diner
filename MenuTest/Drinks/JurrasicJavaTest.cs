using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(false, java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(false, java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.Equal(true, java.Ice);
        }

        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.Equal(true, java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
