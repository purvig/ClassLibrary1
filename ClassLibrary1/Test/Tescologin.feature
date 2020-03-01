Feature: Tescologin
	In order to sign in tesco
	As a user i am able to go tesco website
	I want to be told the sum of two numbers

@regression
Scenario: Tesco login
	Given I navigate to Tesco website
	When I click on sign in button
	And I entered the userdetails
	Then I am able to sign in Tesco
