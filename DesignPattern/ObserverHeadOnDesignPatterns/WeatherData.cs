using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.ObserverHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.ObserverHeadOnDesignPatterns
{
    internal class WeatherData : ISubject
    { 
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            // prevent to register the same observer twice
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = _observers.IndexOf(observer);
            if (index >= 0)
            {
                _observers.RemoveAt(index);
                Console.WriteLine($"Removed observer at index: {index}");
            }
        }
    }
}
