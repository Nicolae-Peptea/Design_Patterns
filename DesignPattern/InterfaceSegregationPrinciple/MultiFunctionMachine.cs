using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.InterfaceSegregationPrinciple
{
    internal class MultiFunctionMachine : IMultiFunctionDevice
    {
        //public void Print(Document document)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Scan(Document document)
        //{
        //    throw new NotImplementedException();
        //}

        // DECORATOR PATTERN
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}
