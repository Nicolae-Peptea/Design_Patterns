using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.InterfaceSegregationPrinciple
{
    internal class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document document)
        {
            throw new NotImplementedException();
        }

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
