namespace DesignPattern.CommandPattern.CommandInterface
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
