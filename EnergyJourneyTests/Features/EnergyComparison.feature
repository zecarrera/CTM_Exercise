Feature: EnergyComparison
	In order to find the one that suits me best
	As a customer
	I want to compare energy providers

@smoke
Scenario: Energy Comparison is properly loaded
	Given I have navigated to energy comparison page
	Then the page's title should be  Energy - Compare Gas and Electricity Suppliers | Compare The Market

@acceptance
Scenario Outline: User can provide supplier information
	Given I have entered a post code <postCode>
	And I have entered the bill handy <billHandy>
	And I have selected what to compare <compareItem>
	When I click next
	Then Your Energy Form is displayed 
	Examples: 
			| postCode | billHandy | compareItem |
			| PE2 6YS  | False     | Gas Only    |
			| PE2 6YS  | True     | Gas Only    | 
			| PE2 6YS  | False     | Electricity Only    | 
			| PE2 6YS  | True     | Electricity Only    | 
				| PE2 6YS  | False     | both    | 
			| PE2 6YS  | True     | both    | 

