using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.DependencyInversionPrinciple
{
    internal class Relashionships : IRelationshipBrowser
    {
        //low level module

        public List<(Person, Relationship, Person)> Relations { get; private set; } =
             new List<(Person, Relationship, Person)>();


        public void AddParentAndChild(Person parent, Person child)
        {
            Relations.Add((parent, Relationship.Parent, child));
            Relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return Relations
                .Where(x => x.Item1.Name == name &&
                        x.Item2 == Relationship.Parent)
                .Select(x => x.Item3);
        }
    }
}
