using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsability
{
    internal interface ICreatureModifier
    {
        void Add(CreatureModifier creatureModifier);
        void Handle();
    }
}
