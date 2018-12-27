namespace CompoundPattern
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuakable CreateDuckCalls()
        {
            return new DuckCalls();
        }

        public override IQuakable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuakable CreateRedhedDuck()
        {
            return new RedheadDuck();
        }

        public override IQuakable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
