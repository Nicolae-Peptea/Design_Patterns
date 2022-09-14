
namespace DesignPattern.DependencyInversionPrinciple
{
    internal class ExecuteDependecyInversion
    {
       public void ExecuteCode()
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
