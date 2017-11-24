Feature: Registration
	In order to get access to application functionality
	As a new user
	I want to be able to create an account (sign up)

Background: Go to registration
Given I press SignUp on authorization


@Registration
Scenario: Successful registration
	Given I have entered a valid email adress in registration
	And I press NEXT from email
	And I have entered a valid phone number in registration
	And I press NEXT from phone
	And I have entered valid names in registration
	And I press NEXT from names
	And I have entered valid password in registration
	When I press Sign UP 
	Then the result should be message about successful registration

	@Authorization by token after registration
Scenario: Authorization after registration
	Given I have entered a valid email adress in registration
	And I press NEXT from email
	And I have entered a valid phone number in registration
	And I press NEXT from phone
	And I have entered valid names in registration
	And I press NEXT from names
	And I have entered valid password in registration
	When I press Sign UP 
	Then the result should be favorites page

	@Invalid email
Scenario: Invalid email
	Given I have entered invalid email adress in registration
	When I press NEXT from email
	Then the result should be email page (no transition)

	@Invalid phone
Scenario: Invalid phone
	Given I have entered a valid email adress in registration
	And I press NEXT from email
	And I have entered an ivalid phone number in registration
	When I press NEXT from phone
	Then the result should be phone page (no transition)

	@Invalid names
Scenario: Invalid names
	Given I have entered a valid email adress in registration
	And I press NEXT from email
	And I have entered a valid phone number in registration
	And I press NEXT from phone
	And I have entered invalid names in registration
	When I press NEXT from names
	Then the result should be names page (no transition)


		@Invalid password
Scenario: Invalid password
	Given I have entered a valid email adress in registration
	And I press NEXT from email
	And I have entered a valid phone number in registration
	And I press NEXT from phone
	And I have entered valid names in registration
	And I press NEXT from names
	And I have entered valid password in registration
	When I press Sign UP 
	Then the result should be password page (no transition)