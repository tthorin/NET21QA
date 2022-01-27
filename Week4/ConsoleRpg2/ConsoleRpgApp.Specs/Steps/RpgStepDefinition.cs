using ConsoleRpg2.Models;
using FluentAssertions;

namespace ConsoleRpgApp.Specs.Steps;

[Binding]
public class RpgStepDefinition
{
    private readonly Enemy _enemy = new();
    private Hero _hero = new();

    [Given(@"Cohens attack value is (\d+), his health is (\d+) and his defense is (\d+)")]
    public void GivenCohensAttackValueIsDHisHealthIsDAndHisDefenseIsD(int atk, int hp, int def)
    {
        _hero = new Hero {Atk = atk, Hp = hp, Def = def};
    }

    [When(@"(?:.*) attacks Cohen")]
    public void WhenAttacksCohen()
    {
        _enemy.Attack(_hero);
    }

    [Given(@"the enemy's attack value is (\d+)")]
    public void GivenTheEnemysAttackValueIsD(int atk)
    {
        _enemy.Atk = atk;
    }

    [Then(@"Cohen will have (.*) remaining")]
    public void ThenCohenWillHaveRemaining(int hp)
    {
        _hero.Hp.Should()?.Be(hp);
    }

    [Then(@"Cohen will be dead")]
    public void ThenCohenWillBeDead()
    {
        _hero.Alive.Should()?.BeFalse();
    }

    [Given(@"the enemy's defense is (\d+) and health is (\d+)")]
    public void GivenTheEnemysDefenseIsAndHealthIs(int def, int hp)
    {
        _enemy.Def = def;
        _enemy.Hp = hp;
    }

    [When(@"Cohen attacks the enemy")]
    public void WhenCohenAttacksTheEnemy() => _hero.Attack(_enemy);

    [Then(@"the enemy will have (\d+) remaining")]
    public void ThenTheEnemyWillHaveRemaining(int hp) => _enemy.Hp.Should()?.Be(hp);
}