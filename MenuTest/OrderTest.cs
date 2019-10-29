/* OrderTest.cs
 * Author: Milan Minocha
 */
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Class for the testing of the order class.
    /// </summary>
    public class OrderTest
    {

        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            Order o = new Order();
            JurassicJava j = new JurassicJava();
            j.Price = -30;
            o.Add(j);
            Assert.True(o.SubtotalCost >= 0, "The subtotal cost was negative.");
        }

        [Fact]
        public void KnownOrder1ShouldHaveCorrectCosts()
        {
            Order o = new Order();
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            o.Add(j);
            Brontowurst b = new Brontowurst();
            o.Add(b);
            Fryceritops f = new Fryceritops();
            o.Add(f);

            Assert.Equal(7.84, o.SubtotalCost, 2);
            Assert.Equal(.5096, o.SalesTaxCost, 2);
            Assert.Equal(8.3496, o.TotalCost, 2);
        }

    }
}
