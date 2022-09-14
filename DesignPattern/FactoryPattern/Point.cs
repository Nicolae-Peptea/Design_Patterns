﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPattern.FactoryPattern
{
    internal class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

    }
}
