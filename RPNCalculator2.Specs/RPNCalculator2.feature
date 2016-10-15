Feature: RPNCalculator2
	In order to have good math notes
	As a polish
	I want to make computations

@mytag
Scenario Outline: Add two numbers
	Given I have entered <comand> into the calculator
	When I press enter
	Then the result should be <result>
	Examples: 
	| command | result |
	| "2"     | 2      |
	| "4"     | 4      |
	| "2 2 +" | 4      |
	| "4 2 +" | 6      |
	| "5 0 +" | 5      |
