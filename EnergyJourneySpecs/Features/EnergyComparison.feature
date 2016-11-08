Feature: EnergyComparison
	In order to find the one that suits me best
	As a customer
	I want to compare energy providers

@acceptance
Scenario Outline: User can get electricity comparison results
	Given I am at the energy comparison page
	And I have entered a post code <postCode>
	And I have selected what to compare <compareItem>
	When I click next
	Then Your Energy Form is displayed 
	And I have entered electricity usage <electricityUsage>
	When I click next at energy form
	Then Your Details Form is displayed
	And I select tariff type
	And I select payment type
	And I enter my email <email>
	And I accept the terms & conditions
	When I click go to prices at Your details
	Then Your results page is displayed
	Examples: 
			| postCode | compareItem      | electricityUsage | email   |
			| PE2 6YS  | Electricity Only | 300              | t@t.com |

@acceptance
Scenario Outline: User can provide supplier information
	Given I have entered a post code <postCode>
	And I have entered the bill handy <billHandy>
	And I have selected what to compare <compareItem>
	When I click next
	Then Your Energy Form is displayed 
	Examples: 
			| postCode | billHandy | compareItem      |
			| PE26YS  | False     | Gas Only         |
			| PE26YS  | True      | Gas Only         |
			| PE26YS  | False     | Electricity Only |
			| PE2 6YS  | True      | Electricity Only |
			| PE2 6YS  | False     | both             |
			| PE2 6YS  | True      | both             |

@acceptance
Scenario Outline: User can't proceed if invalid post code is provided
	Given I have entered a post code <postCode>
	Then Post code error is displayed
	Examples: 
			| postCode |
			| PE2      |
			|PE26YSP   |
			|          |