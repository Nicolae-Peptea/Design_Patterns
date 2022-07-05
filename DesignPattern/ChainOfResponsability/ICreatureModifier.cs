namespace DesignPattern.ChainOfResponsability
{
    internal interface ICreatureModifier
    {
        void Add(CreatureModifier creatureModifier);
        void Handle();
    }
}
