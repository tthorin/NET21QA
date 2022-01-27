namespace ConsoleRpg2.Interfaces;

public interface ICreature
{
    int Hp { get; set; }
    int Atk { get; set; }
    int Def { get; set; }
    bool Alive { get; }

    void Attack(ICreature target);

    void Defend(int attack);
}