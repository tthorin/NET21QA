using System.Reflection.Metadata;
using ConsoleRpgApp.Models;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace ConsoleRpgApp.Specs.Steps;

[Binding]
public class RpgStepDefinition
{
    private Hero _hero=new();
    private Enemy _enemy=new();
    
    [Given(@"Cohens attack value is (\d+), his health is (\d+) and his defense is (\d+)")]
    public void GivenCohensAttackValueIs(int atk,int hp,int def)
    {
        _hero = new() {Atk = atk,Hp = hp,Def = def};
    }

    [When(@"(?:.*) attacks Cohen")]
    public void WhenTheTrollsStrikesBack()
    {
        _enemy.Attack(_hero);
    }
    
    [Given(@"the enemy's attack value is (\d+)")]
    public void GivenTheEnemysAttackValueIs(int atk)
    {
        _enemy.Atk = atk;
    }

    [Then(@"Cohen will have (.*) remaining")]
    public void ThenCohenWillHaveRemaining(int hp)
    {
        _hero.Hp.Should().Be(hp);
    }

    [Then(@"Cohen will be dead")]
    public void ThenChohenWillBeDead()
    {
        _hero.Alive.Should().BeFalse();
    }
}