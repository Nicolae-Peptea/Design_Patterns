using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.InterfaceSegregationPrinciple
{
    internal class Photocopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
