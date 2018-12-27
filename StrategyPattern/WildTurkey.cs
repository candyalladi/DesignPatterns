using System;

namespace DesignPatterns
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying !");
        }

        public void Globble()
        {
            Console.WriteLine("I Globble Globble !");
        }
    }

    public class TurkeyAdapter : Duck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        
        public void Quak()
        {
            turkey.Globble();
        }

        public void Fly()
        {
            turkey.Fly();
        }

        public override void Display()
        {
            Console.WriteLine("I am Turkey Adapter!");
        }
    }
}
