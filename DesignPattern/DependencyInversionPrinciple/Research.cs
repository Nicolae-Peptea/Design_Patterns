using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        static void Main(string[] args)
        {
            Person parent = new Person { Name = "John" };
            Person firstChild = new Person { Name = "Chris" };
            Person secondChild = new Person { Name = "MAry" };

            Relashionships relashionships = new Relashionships();
            relashionships.AddParentAndChild(parent, firstChild);
            relashionships.AddParentAndChild(parent, secondChild);

            new Research(relashionships);

        }


    }
}
