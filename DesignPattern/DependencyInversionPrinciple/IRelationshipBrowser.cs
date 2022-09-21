using System.Collections.Generic;

namespace DesignPattern.DependencyInversionPrinciple
{
    internal interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
