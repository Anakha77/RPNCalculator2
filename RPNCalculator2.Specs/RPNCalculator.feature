Feature: RPNCalculator
	In order to have good math notes
	As a polish
	I want to make computations

@mytag
Scenario Outline: Compute operation
	Given I have entered <command> into the calculator
	When I Compute the command
	Then the result should be <result>
	Examples: 
	| command           | result |
	| 2                 | 2      |
	| 2 2 +             | 4      |
	| 1 6 +             | 7      |
	| 1 2 -             | -1     |
	| 2 3 *             | 6      |
	| 9 3 /             | 3      |
	| 5 3 4 - *         | -5     |
	| 3 4 5 * -         | -17    |
	| 3 4 - 5 *         | -5     |
	| 5 1 2 + 4 * + 3 - | 14     |

