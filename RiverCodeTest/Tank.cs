using System.Collections.Generic;
using System.Data;

namespace RiverCodeTest
{
    public class Tank
    {
        public List<Fish> Fish;

        public Tank()
        {
            Fish = new List<Fish>();
        }

        public string Count()
        {
            return Fish.Count.ToString();
        }

        public void AddFish(Fish fish)
        {
            if(Fish.TrueForAll(b => b.Name != fish.Name))
            {
                Fish.Add(fish);
            }
            else
            {
                throw new DuplicateNameException();
            }

        }

        public double Feed()
        {
            var result = 0.0;
            
            if(Fish != null)
            {
                foreach (Fish fishy in Fish)
                {
                    result += fishy.FoodInGrams;
                }
            }
            
            return result;
        }
    }
}
