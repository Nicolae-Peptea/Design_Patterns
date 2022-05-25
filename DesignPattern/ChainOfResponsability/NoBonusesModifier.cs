using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsability
{
    internal class NoBonusesModifier : CreatureModifier
    {
        public NoBonusesModifier(Creature creature)
            : base(creature)
        {

        }

        public override void Handle()
        {
        }
    }
}
