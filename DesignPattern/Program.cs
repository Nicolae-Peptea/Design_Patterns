using DesignPattern.AbstractFactoryVisualStudio;
using DesignPattern.StrategyHeadOnDesignPatterns;
using System;
using System.Text;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new StrategyPatternHeadsOnDesignPatternsSimulator();
            test.Execute();
        }
    }
}
