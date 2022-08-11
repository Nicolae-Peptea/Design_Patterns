using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInversionPrinciple
{
    internal interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
