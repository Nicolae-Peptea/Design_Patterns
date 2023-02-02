using DesignPattern.AbstractFactoryVisualStudio;
using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var test = new ExecuteFactory();
            //test.ExecuteCode();
            //var test = new ExecuteFactoryObjWithOCP_V2();
            //test.ExecuteCode();

            //var test = new ExecuteAbstractFactoryWithOCP();
            //test.Execute();
            ExecuteAbstractFactoryVisualStudio.Execute();
        }
    }
}
