using System;

namespace DesignPatterns
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly!");
        }
    }
}
