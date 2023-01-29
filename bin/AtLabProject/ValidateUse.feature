Feature: ValidateUse

@tagUser
Scenario: Validate if user is created 
	Given setup is done
	When user is created
	Then validate user info
