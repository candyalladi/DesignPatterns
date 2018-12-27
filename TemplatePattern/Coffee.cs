using System;

namespace TemplatePattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Milk and Sugar!");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing the Coffee in Water");
        }
    }
}
