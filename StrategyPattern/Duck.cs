namespace DesignPatterns
{
    public abstract class Duck
    {
        public void PerformFly(IFlyBehaviour flyBehaviour)
        {
            flyBehaviour.Fly();
        }

        public void Swim()
        {

        }

        public abstract void Display();
        

        public void PerformQuak(IQuakBehaviour quakBehaviour)
        {
            quakBehaviour.Quak();
        }
    }
}
