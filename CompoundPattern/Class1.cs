using System.Collections.Generic;

namespace CompoundPattern
{
    public interface IQuakable
    {
        void Quack();
    }

    public abstract class AbstractDuckFactory
    {
        public abstract IQuakable CreateMallardDuck();
        public abstract IQuakable CreateRedhedDuck();
        public abstract IQuakable CreateDuckCalls();
        public abstract IQuakable CreateRubberDuck();
    }

    public class Flock : IQuakable
    {
        List<IQuakable> quackers = new List<IQuakable>();

        public void Add(IQuakable quakable)
        {
            quackers.Add(quakable);
        }
        public void Quack()
        {
            IEnumerator<IQuakable> enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IQuakable quakable = enumerator.Current;
                quakable.Quack();
            }
        }
    }
}
