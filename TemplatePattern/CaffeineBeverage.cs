using System;

namespace TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into the Cup!");
        }

        public abstract void AddCondiments();

        public abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("Boiling the Water!");
        }
    }
}
