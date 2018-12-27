namespace ObserverPattern
{
    public interface IObserver
    {
        void update(float temp, float pressure, float humidity);
    }
}
