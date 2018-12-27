using System;

namespace DesignPatterns
{
    public class FlywithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying!");
        }
    }
}
