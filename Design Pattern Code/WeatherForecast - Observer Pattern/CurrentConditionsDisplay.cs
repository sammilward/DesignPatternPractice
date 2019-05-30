﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.WeatherForecast___Observer_Pattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}
