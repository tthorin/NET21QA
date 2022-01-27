using ConsoleRpg2.Interfaces;

namespace ConsoleRpg2.Models;

public class Creature : ICreature
{
    /// <summary>
    /// The hp (health) of the creature
    /// </summary>
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public bool Alive => Hp > 0;

    public void Attack(ICreature target)
    {
        target.Defend(Atk);
    }

    public void Defend(int attack)
    {
        if (attack > Def) Hp -= attack - Def;
    }
}