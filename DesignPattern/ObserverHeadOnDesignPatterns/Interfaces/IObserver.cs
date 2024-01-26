using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverHeadOnDesignPatterns.Interfaces
{
    internal interface IObserver
    {
        public void Update(float temp, float hunidity, float presure);
    }
}
