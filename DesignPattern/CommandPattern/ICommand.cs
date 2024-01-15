
namespace DesignPattern.CommandPattern
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
