﻿using System;

namespace DesignPattern.ChainOfResponsability
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
