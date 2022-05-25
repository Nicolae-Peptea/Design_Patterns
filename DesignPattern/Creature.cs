using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    internal class Creature
    {
        internal int attack;
        internal int defense;
        internal string name;

        public Creature(string name, int attack, int defense)
        {
            this.name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            this.attack = attack;
            this.defense = defense;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(attack)}: {attack} {nameof(defense)}: {defense}";
        }

    }

}
