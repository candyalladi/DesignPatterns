namespace CompoundPattern
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuakable CreateDuckCalls()
        {
            return new QuackCounter(new DuckCalls());
        }

        public override IQuakable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuakable CreateRedhedDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuakable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
