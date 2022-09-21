namespace DesignPattern.Exercises.Factory
{
    public interface IPersonFactory
    {
        IPerson CreatePerson(string name);
    }
}
