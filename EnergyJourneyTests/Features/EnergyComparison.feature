Feature: EnergyComparison
	In order to find the one that suits me best
	As a customer
	I want to compare energy providers

@smoke
Scenario: Energy Comparison is properly loaded
	Given I have navigated to energy comparison page
	Then the page's title should be  Energy - Compare Gas and Electricity Suppliers | Compare The Market
