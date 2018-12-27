namespace CompoundPattern
{
    public class QuackCounter : IQuakable
    {
        IQuakable duck;
        static int numberCounter;

        public QuackCounter(IQuakable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            numberCounter++;
        }

        public static int GetQuackCount()
        {
            return numberCounter;
        }
    }
}
