using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.WeatherForecast___Observer_Pattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
