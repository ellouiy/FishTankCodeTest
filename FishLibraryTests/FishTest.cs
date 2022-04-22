using NUnit.Framework;
using RiverCodeTest;

namespace FishTests
{
    [TestFixture]
    public class FishTest
    {
        [Test]
        public void CreateNewGoldFish_ReturnCorrectName()
        {
            var goldfish = new GoldFish("goldy");

            Assert.AreEqual(goldfish.Name, "goldy");
        }

        [Test]
        public void CreateNewAngelFish_ReturnCorrectName()
        {
            var angelFish = new AngelFish("angel");

            Assert.AreEqual(angelFish.Name, "angel");
        }

        [Test]
        public void CreateNewBabelFish_ReturnCorrectName()
        {
            var babelFish = new BabelFish("hitchhiker's");

            Assert.AreEqual(babelFish.Name, "hitchhiker's");
        }

        [Test]
        public void GoldFishIsAFish_ReturnsTrue()
        {
            Assert.IsTrue(typeof(GoldFish).IsSubclassOf(typeof(Fish)));
        }

        [Test]
        public void AngelFishIsAFish_ReturnsTrue()
        {
            Assert.IsTrue(typeof(AngelFish).IsSubclassOf(typeof(Fish)));
        }

        [Test]
        public void BabelFishIsAFish_ReturnsTrue()
        {
            Assert.IsTrue(typeof(BabelFish).IsSubclassOf(typeof(Fish)));
        }
    }
}
