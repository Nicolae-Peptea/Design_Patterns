using System;

namespace DesignPattern.ChainOfResponsability
{
    internal class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature)
            : base(creature)
        {
        }

        public override void Handle()
        {
            Console.WriteLine($"Doubling {creature.name}'s attack");
            creature.attack *= 2;
            base.Handle();
        }
    }
}
