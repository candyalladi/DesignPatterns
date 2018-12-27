using System;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Switching on Light!");
        }

        public void Off()
        {
            Console.WriteLine("Light is Switched Off!");
        }
    }
}
