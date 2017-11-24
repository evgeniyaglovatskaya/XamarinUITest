Feature: OpenDeal
	In order to open deal
	As a math trader
	I want to be able to enter amount and choose deal type

Background: Authorize
Given I closed all deals (that could be closed)
And I have checked number of already opened deals


@Sell currency
Scenario: Open deal for currency by Sell 
	Given I have opened currency open deal dialog
	And I have tapped on Sell button
	When I press Yes in confirmation message
	Then the result should be new deal in opened deals list

@Buy currency
Scenario: Open deal for currency by Buy 
	Given I have opened currency open deal dialog
	And I have tapped on Buy button
	When I press Yes in confirmation message
	Then the result should be new deal in opened deals list

@Sell commodities
Scenario: Open deal for commodity by Sell 
	Given I have opened commodity open deal dialog
	And I have tapped on Sell button
	When I press Yes in confirmation message
	 Then the result should be new deal in opened deals list

@Sell indexes
Scenario: Open deal for index by Sell 
	Given I have opened index open deal dialog
	And I have tapped on Sell button
	When I press Yes in confirmation message
	Then the result should be new deal in opened deals list

@Sell stocks
Scenario: Open deal for stocks by Sell 
	Given I have opened stocks open deal dialog
	And I have tapped on Sell button
	When I press Yes in confirmation message
	Then the result should be new deal in opened deals list

@Invalid amount
Scenario: Try to open deal with invalid amount 
	Given I have opened currency open deal dialog
	And I have entered an invalid amount
	And I have tapped on Sell button
	Then the result should be is error message that amount is invalid
