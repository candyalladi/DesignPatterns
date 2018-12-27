using System;

namespace CompoundPattern
{
    public class DuckCalls : IQuakable
    {
        public void Quack()
        {
            Console.WriteLine("Kuack!");
        }
    }
}
