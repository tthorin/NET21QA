namespace ConsoleRpgApp.Models;

public class Hero:Creature
{
    public bool Alive { get=>Hp>0;  }
}