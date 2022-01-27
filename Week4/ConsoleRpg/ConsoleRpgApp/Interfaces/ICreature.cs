namespace ConsoleRpgApp.Interfaces;
using ConsoleRpgApp.Models;
public interface ICreature
{
    int Hp { get; set; }
    int Atk { get; set; }
    int Def { get; set; }
    void Attack(ICreature target);
    void Defend(int attack);
}