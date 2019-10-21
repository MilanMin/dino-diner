/* CretaceousComboTest.cs
 * Author: Milan Minocha
 */
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {

        [Fact]
        public void SpecialShouldHaveCorrectVelociWrapAndDescriptons()
        {
            VelociWrap vw = new VelociWrap();
            CretaceousCombo cc = new CretaceousCombo(vw);

            vw.HoldCheese();
            JurassicJava jj = new JurassicJava();
            cc.Drink = jj;

            Fryceritops ft = new Fryceritops();
            cc.Side = ft;

            string[] special = cc.Special;

            Assert.Collection<string>(cc.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                },
                item =>
                {
                    Assert.Equal("Small Fryceritops", item);
                },
                item =>
                {
                    Assert.Equal("Small Jurassic Java", item);
                }
            );
        }

    }
}
