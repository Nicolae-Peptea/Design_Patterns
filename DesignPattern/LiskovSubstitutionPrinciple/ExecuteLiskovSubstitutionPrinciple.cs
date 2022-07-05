using System;

namespace DesignPattern.LiskovSubstitutionPrinciple
{
    internal class ExecuteLiskovSubstitutionPrinciple
    {
        public void ExecuteCode()
        {
            Rectangle rectangle = new Rectangle(5, 6);
            Rectangle square = new Square();
            square.Width = 5;

            Console.WriteLine($"{rectangle} has area of {rectangle.Area()}");
            Console.WriteLine($"{square} has area of {square.Area()}");
        }

    }
}
