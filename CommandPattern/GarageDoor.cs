using System;

namespace CommandPattern
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Door is up!");
        }

        public void Down()
        {
            Console.WriteLine("Door is down!");
        }

        public void Stop()
        {
            Console.WriteLine("Door is stopped!");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Light is On!");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage ight is Off!");
        }
    }
}
