using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPattern.SingleResponsabilityPrinciple
{
    internal class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }
    }
}
