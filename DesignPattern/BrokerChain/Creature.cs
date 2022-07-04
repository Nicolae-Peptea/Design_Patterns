using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BrokerChain
{
    public class Creature
    {
        private Game game;
        public string name;
        private int attack;
        private int defense;

        public Creature(Game game, string name, int attack, int defense)
        {
            this.game = game ?? throw new ArgumentNullException(nameof(game));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.attack = attack;
            this.defense = defense;
        }

        public int Attack
        { 
            get
            {
                var query = new Query(name, Query.Argument.Attack, attack);
                game.PerformQuery(this, query);
                return query.Value; 
            }
        }
    }
}
