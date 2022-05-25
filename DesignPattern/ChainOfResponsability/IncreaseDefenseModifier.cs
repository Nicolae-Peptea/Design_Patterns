using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsability
{
    internal class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature)
            : base(creature)
        {
        }

        public override void Handle()
        {
            Console.WriteLine($"Increaseing {creature.name}'s defense");
            creature.defense += 3;
            base.Handle();
        }
    }
}
