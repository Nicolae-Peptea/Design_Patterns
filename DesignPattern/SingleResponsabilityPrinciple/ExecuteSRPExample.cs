using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPattern.SingleResponsabilityPrinciple
{
    internal class ExecuteSRPExample
    {
        public void ExecuteCode()
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            Persistance persistance = new Persistance();
            string filename = "C:\\journal.txt";

            persistance.SaveToFile(j, filename, true);
            Process.Start(filename);
        }


        
    }
}
