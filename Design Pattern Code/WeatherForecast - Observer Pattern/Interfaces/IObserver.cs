using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.WeatherForecast___Observer_Pattern
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
