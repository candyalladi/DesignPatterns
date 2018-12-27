namespace CompoundPattern
{
    public class GooseAdapter : IQuakable
    {
        Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }
    }
}
