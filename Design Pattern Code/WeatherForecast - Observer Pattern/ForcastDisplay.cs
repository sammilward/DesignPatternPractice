using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.WeatherForecast___Observer_Pattern
{
    public class ForcastDisplay : IObserver, IDisplay
    {
        private float pressure;
        private ISubject weatherData;

        public ForcastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            if (pressure <= 10) Console.WriteLine("Forecast: There is low pressure today at: " + pressure);
            else if (pressure <= 20) Console.WriteLine("Forecast: There is medium pressure today at: " + pressure);
            else if (pressure <= 35) Console.WriteLine("Forecast: There is high pressure today at: " + pressure);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.pressure = pressure;
            Display();
        }
    }
}


