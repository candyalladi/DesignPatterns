using System;
    
namespace DesignPatterns
{
    public class MuteQuak : IQuakBehaviour
    {
        public void Quak()
        {
            Console.WriteLine("I don't Quak!");
        }
    }
}
