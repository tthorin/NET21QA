using ConsoleRpgApp.Interfaces;

namespace ConsoleRpgApp.Models;

public class Creature : ICreature
{
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }

    public void Attack(ICreature target)
    {
        target.Defend(Atk);
    }

    public void Defend(int attack)
    {
        Hp = attack > Def ? Hp + Def - attack : Hp;
    }
}