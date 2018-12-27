using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            foreach (var item in observers)
            {
                IObserver observer = (IObserver)item;
                observer.update(temp, pressure, humidity);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temp, float pressure, float humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;

            measurementsChanged();
        }
    }
}
