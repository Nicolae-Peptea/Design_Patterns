using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.ObserverHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.ObserverHeadOnDesignPatterns
{
    internal class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: temperature {_temperature}, humidity: {_humidity}");
        }

        public void Update(float temp, float humidity, float presure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
