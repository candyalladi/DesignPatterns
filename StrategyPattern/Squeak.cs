using System;

namespace DesignPatterns
{
    public class Squeak : IQuakBehaviour
    {
        public void Quak()
        {
            Console.WriteLine("I Squeak!");
        }
    }
}
