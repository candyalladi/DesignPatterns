using System;

namespace DesignPatterns
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am mallard Duck !");
        }
    }

    public class RoboDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am Robo Duck!");
        }
    }
}
