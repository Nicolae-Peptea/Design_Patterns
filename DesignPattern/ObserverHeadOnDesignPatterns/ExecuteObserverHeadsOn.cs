using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverHeadOnDesignPatterns
{
    internal class ExecuteObserverHeadsOn
    {
        public void Execute()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            weatherData.RemoveObserver(currentDisplay);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            weatherData.RegisterObserver(currentDisplay);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
