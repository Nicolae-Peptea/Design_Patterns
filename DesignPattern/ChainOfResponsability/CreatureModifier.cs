using System;

namespace DesignPattern.ChainOfResponsability
{
    internal abstract class CreatureModifier : ICreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier next; // linked list

        public CreatureModifier(Creature creature)
        {
            this.creature = creature ?? throw new ArgumentNullException(paramName: nameof(creature));
        }

        public void Add(CreatureModifier creatureModifier)
        {
            if (next != null)
            {
                next.Add(creatureModifier);
            }
            else
            {
                next = creatureModifier;
            }
        }

        public virtual void Handle()
        {
            next?.Handle();
        }
    }
}
