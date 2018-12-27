using System;

namespace DesignPatterns
{
    public class Quack : IQuakBehaviour
    {
        public void Quak()
        {
            Console.WriteLine("I sound Quak!");
        }
    }
}
