Feature: JugadoresOutlineScenario
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Players add some games
	Given the player is in game
	And the player click on play and write"<Nickname>"
	And the player click new game for <Npartida>
	When the game plays with the players
	Then the result of all ngames should be a "<Npartidas>"

	Examples: 
	| Nickname  | Npartida | Npartidas |
	| Pachuka1  | 2        | 2         |
	| Pachuka2  | 2        | 2         |
	| Pachuka3  | 2        | 2         |