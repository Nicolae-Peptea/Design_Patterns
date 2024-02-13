﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
