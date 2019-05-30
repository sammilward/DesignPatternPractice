using System.Collections.Generic;

namespace Design_Pattern_Code.WeatherForecast___Observer_Pattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;


        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
