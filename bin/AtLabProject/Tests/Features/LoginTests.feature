Feature: LoginTests
I want to be able load the login page and see homepage (vitrine)

@smoke
Scenario: Login page should open
	Then Login page is opened

@CriticalPath
Scenario: Enterining correct login and password I should see webshop's vitrine
	When I type correct '<login>' and password
	Then Homepage is opened	
	Examples: 
	| login                   |
	| standard_user           | 
	| problem_user            | 
	| performance_glitch_user | 


