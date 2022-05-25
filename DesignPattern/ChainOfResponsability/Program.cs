using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            CreatureModifier root = new CreatureModifier(goblin);

            NoBonusesModifier noBonuses = new NoBonusesModifier(goblin);

            root.Add(noBonuses);

            Console.WriteLine("Let's double the goblin's attack");
            DoubleAttackModifier doubleAttackModifier = new DoubleAttackModifier(goblin);
            root.Add(doubleAttackModifier);

            Console.WriteLine("Let's increase the goblin's defense");
            IncreaseDefenseModifier increaseDefenseModifier = new IncreaseDefenseModifier(goblin);
            root.Add(increaseDefenseModifier);

            root.Handle();

            Console.WriteLine(goblin);
        }
    }
}
