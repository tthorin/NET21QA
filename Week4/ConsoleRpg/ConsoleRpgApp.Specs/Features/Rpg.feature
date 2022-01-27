Feature: Rpg
simple console rpg

Scenario Outline: Our hero Cohen meets diffrent enemies
    Given Cohens attack value is 50, his health is 100 and his defense is 50
    And the enemy's attack value is <atk>
    When the enemy attacks Cohen
    Then Cohen will have <hp> remaining
    Examples: 
    | atk | hp  |
    | 25  | 100 |
    | 75  | 75  |
    | 151 | -1  |
    
Scenario: Cohen gets chomped on by a dragon
    Given Cohens attack value is 50, his health is 100 and his defense is 50
    And the enemy's attack value is 151
    When the dragon attacks Cohen
    Then Cohen will be dead