using DesignPattern.AbstractFactory;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new ExecuteAbstractFactory();
            test.Execute();
        }
    }
}
