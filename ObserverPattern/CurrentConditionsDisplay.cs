using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float temp;
        private float pressure;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine($"Current Conditions : {temp} F degrees and {humidity} % humidity {pressure}");
        }

        public void update(float temp, float pressure, float humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;

            display();
        }
    }
}
