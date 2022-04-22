using RiverCodeTest;
using System;

namespace ShowFishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new Tank();
            var goldFish = new GoldFish("Goldilocks");
            var angelFish = new AngelFish("Angelo");
            var babelFish = new BabelFish("Slartibartfast");

            tank.AddFish(goldFish);
            Console.WriteLine($"You have {tank.Fish.Count} in the tank at the moment");
            Console.WriteLine($"and you need {tank.Feed()} grams of food to feed them :)");

            tank.AddFish(angelFish);
            Console.WriteLine($"You have {tank.Fish.Count} in the tank at the moment");
            Console.WriteLine($"and you need {tank.Feed()} grams of food to feed them :)");

            tank.AddFish(babelFish);
            Console.WriteLine($"You have {tank.Fish.Count} in the tank at the moment");
            Console.WriteLine($"and you need {tank.Feed()} grams of food to feed them :)");

        }
    }
}
