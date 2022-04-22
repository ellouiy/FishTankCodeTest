using NUnit.Framework;
using RiverCodeTest;
using System.Data;

namespace FishTests
{

    [TestFixture]
    public class TankTest
    {
        private  GoldFish goldfish;
        private readonly AngelFish angelfish;
        private readonly BabelFish babelfish;

        public TankTest()
        {
            goldfish = new GoldFish("goldy");
            angelfish = new AngelFish("angelHalo");
            babelfish = new BabelFish("earTranslatorFish");
        }

        [Test]
        public void TankExists_AddFishCorrectly()
        {
            var tank = new Tank();
            tank.AddFish(goldfish);

            Assert.AreEqual(1, tank.Fish.Count);
        }

        [Test]
        public void TankExists_AddMultipleFish()
        {
            var tank = new Tank();
            tank.AddFish(angelfish);
            tank.AddFish(babelfish);

            Assert.AreEqual(2, tank.Fish.Count);
        }

        [Test]
        public void TankExists_FeedOneTypeOfFish()
        {
            var tank = new Tank();
            tank.AddFish(angelfish);

           var expectedFoodInGrams = 0.2;

            var actualFoodInGrams = tank.Feed();

            Assert.AreEqual(expectedFoodInGrams, actualFoodInGrams);
        }

        [Test]
        public void TankExists_FeedMultipleTypesOfFish()
        {
            var tank = new Tank();
            tank.AddFish(angelfish);
            tank.AddFish(goldfish);

            var expectedFoodInGrams = 0.2 + 0.1;

            var actualFoodInGrams = tank.Feed();

            Assert.AreEqual(expectedFoodInGrams, actualFoodInGrams);

        }

        [Test]
        public void AddSameFishType_ThrowException()
        {
            var tank = new Tank();
            tank.AddFish(goldfish);

            Assert.Throws<DuplicateNameException>(() => tank.AddFish(goldfish));
        }
    }
}
