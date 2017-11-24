Feature: Registration
	In order to get access to application functionality
	As a new user
	I want to be able to create an account (sign up)

@mytag
Scenario: Successful registration
	Given I have entered a valid email adress in registration
	And I have entered a valid phone number in registration
	And I have entered valid names in registration
	And I have entered valid password in registration
	When I press Sign
	Then the result should be 120 on the screen
