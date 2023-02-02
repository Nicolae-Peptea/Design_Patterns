using System;

namespace DesignPattern.DependencyInversionPrinciple
{
    internal class Research
    {
        public Research(IRelationshipBrowser relationshipBrowser)
        {
            foreach (var person in relationshipBrowser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {person.Name}");
            }
        }
    }
}
 