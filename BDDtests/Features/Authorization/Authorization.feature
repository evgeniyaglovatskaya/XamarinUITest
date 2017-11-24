Feature: Authorization
	In order to get access to mobile trading platform
	As a registered user
	I want to be able to authorize in app

@positive
Scenario: Authorization with valid data
	Given I have entered valid and existing email to email field
	And I have entered correct password into password field
	When I press log in
	Then the result I should see is favorites screen

@negative
Scenario: Authorization with invalid data
    Given I have entered invalid and existing email to email field
	And I have entered incorrect password into password field
	When I press log in
	Then the result I should see authorization page
