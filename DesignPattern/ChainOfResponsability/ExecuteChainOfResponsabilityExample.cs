using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsability
{
    internal class ExecuteChainOfResponsabilityExample
    {
        public void ExecuteCode()
        {
            //Chain Of responsability

            Creature goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            //NoBonusesModifier noBonuses = new NoBonusesModifier(goblin);

            //root.Add(noBonuses);

            Console.WriteLine("Let's double the goblin's attack");
            DoubleAttackModifier doubleAttackModifier = new DoubleAttackModifier(goblin);
            //root.Add(doubleAttackModifier);

            Console.WriteLine("Let's increase the goblin's defense");
            IncreaseDefenseModifier increaseDefenseModifier = new IncreaseDefenseModifier(goblin);
            doubleAttackModifier.Add(increaseDefenseModifier);

            doubleAttackModifier.Handle();

            Console.WriteLine(goblin);

        }
    }
}
