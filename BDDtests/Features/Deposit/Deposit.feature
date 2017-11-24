Feature: Deposit
	In order to make trading operations
	As a trader
	I want to be able to make deposit 

Background: 
Given I check current account balance

@Transition from toolbar
Scenario: Transition to deposit from toolbar
	Given I have tapped on button Deposit in toolbar
	Then the result should be Visa deposit page

@Transition from drawer
Scenario: Transition to deposit from drawer
	Given I have tapped on button Deposit in drawer
	Then the result should be Visa deposit page

@Visa credit card
Scenario: Make deposit using Visa credit card
	Given I have tapped on button Deposit in toolbar
	And I enter deposit amount for Visa credit card
	And I enter card number or Visa credit card
	And I enter card owner name for Visa credit card
	And I enter card mounth and year for Visa credit card
	And I enter card CVV code for Visa credit card
	When I tap on button send for Visa credit card
	Then the result i sholud see is account balance increased by deposit amount


@Visa 3d secure
Scenario: Make deposit using Visa 3d secure
	Given I have tapped on button Deposit in toolbar
	And I go to Visa d secure
	And I enter deposit amount for Visa d secure
	And I enter card number for Visa d secure
	And I enter card owner name for Visa d secure
	And I enter card mounth and year for Visa d secure
	And I enter card CVV code for Visa d secure
	When I tap on button send for Visa d secure
	Then the result i sholud see is account balance increased by deposit amount

	
@Online wire transfer
Scenario: Make deposit using Online wire transfer
	Given I have tapped on button Deposit in toolbar
	And I go to online wire transfer
	And I enter deposit amount for online wire transfer
	When I tap on button send for online wire transfer
	Then the result i sholud see is account balance increased by deposit amount

@CashU
Scenario: Make deposit using CashU
	Given I have tapped on button Deposit in toolbar
	And I go to CashU
	And I enter deposit amount for CashU
	When I tap on button send for CashU
	Then the result i sholud see is account balance increased by deposit amount

@Neteller
Scenario: Make deposit using Neteller
	Given I have tapped on button Deposit in toolbar
	And I go to Neteller
	And I enter deposit amount for Neteller
	When I tap on button send for Neteller
	Then the result i sholud see is account balance increased by deposit amount

@Wallet one
Scenario: Make deposit using Wallet One
	Given I have tapped on button Deposit in toolbar
	And I go to Wallet One
	And I enter deposit amount for Wallet One
	When I tap on button send for Wallet One
	Then the result i sholud see is account balance increased by deposit amount

@Yandex Money
Scenario: Make deposit using Yandex Money
	Given I have tapped on button Deposit in toolbar
	And I go to Yandex money
	And I enter deposit amount for Yandex money
	When I tap on button send for Yandex money
	Then the result i sholud see is account balance increased by deposit amount


@Qiwi wallet
Scenario: Make deposit using Qiwi wallet
	Given I have tapped on button Deposit in toolbar
	And I go to Qiwi wallet
	And I choose USD for Qiwi wallet
	And I enter deposit amount for Qiwi wallet
	When I tap on button send for Qiwi wallet
	Then the result i sholud see is account balance increased by deposit amount

@Web money
Scenario: Make deposit using Web money
	Given I have tapped on button Deposit in toolbar
	And I go to Web money
	And I enter deposit amount for Web money
	When I tap on button send for Web money
	Then the result i sholud see is account balance increased by deposit amount

@Yuu Pay
Scenario: Make deposit using Yuu Pay
	Given I have tapped on button Deposit in toolbar
	And I go to YuuPay
	And I choose USD for YuuPay
	And I enter deposit amount for YuuPay
	When I tap on button send for YuuPay
	Then the result i sholud see is account balance increased by deposit amount

@Moneta.tu
Scenario: Make deposit using Moneta.ru
	Given I have tapped on button Deposit in toolbar
	And I go to Moneta.ru
	And I enter deposit amount for Moneta.ru
	When I tap on button send Moneta.ru
	Then the result i sholud see is account balance increased by deposit amount

@Boleto
Scenario: Make deposit using Boleto
	Given I have tapped on button Deposit in toolbar
	And I go to Boleto
	And I enter deposit amount for Boleto
	When I tap on button send for Boleto
	Then the result i sholud see is account balance increased by deposit amount

@Astropay
Scenario: Make deposit using Astropay
	Given I have tapped on button Deposit in toolbar
	And I go to Astropay
	And I enter deposit amount for Astropay
	When I tap on button send for Astropay
	Then the result i sholud see is account balance increased by deposit amount

@Alfa-Bank
Scenario: Make deposit using Alfa-Bank
	Given I have tapped on button Deposit in toolbar
	And I go to Alfa-Bank
	And I enter deposit amount for Alfa-Bank
	When I tap on button send for Alfa-Bank
	Then the result i sholud see is account balance increased by deposit amount

@Promsvyazbank
Scenario: Make deposit using Promsvyazbank
	Given I have tapped on button Deposit in toolbar
	And I go to Promsvyazbank
	And I enter deposit amount for Promsvyazbank
	When I tap on button send for Promsvyazbank
	Then the result i sholud see is account balance increased by deposit amount

@Aonpay
Scenario: Make deposit using Aonpay
	Given I have tapped on button Deposit in toolbar
	And I go to Aonpay Visa
	And I enter deposit amount for Aonpay Visa
	And I enter first/last name for Aonpay Visa
	And I enter email for Aonpay Visa
	And I enter phone for Aonpay Visa
	And I enter country for Aonpay Visa
	And I enter city for Aonpay Visa
	And I enter adress for Aonpay Visa
	And I enter post index for Aonpay Visa
	When I tap on button send for Aonpay Visa
	Then the result i sholud see is account balance increased by deposit amount