using System;
using NUnit.Core;
using PortableUI;
using TechTalk.SpecFlow;

namespace BDDtests.Steps
{
    [Binding]
    public class DepositSteps:StepBase
    {
        [Given(@"I check current account balance")]
        public void GivenICheckCurrentAccountBalance()
        {
            double balance = Helper.CheckBalance();
            ScenarioContext.Current.Add("AccountBalance",balance);
        }
        
        [Given(@"I have tapped on button Deposit in toolbar")]
        public void GivenIHaveTappedOnButtonDepositInToolbar()
        {
            App.Tap(Resources.Screen.Tools.Deposit_Btn);
        }
        
        [Given(@"I have tapped on button Deposit in drawer")]
        public void GivenIHaveTappedOnButtonDepositInDrawer()
        {
            Helper.Swipe(Resources.Screen.Favorites.Card);
            Helper.TransitionFromDrawer(Resources.Screen.Drawer.Balances);
        }
        
        [Given(@"I enter deposit amount for Visa credit card")]
        public void GivenIEnterDepositAmountForVisaCreditCard()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.DepositAmount, "1");
        }
        
        [Given(@"I enter card number or Visa credit card")]
        public void GivenIEnterCardNumberOrVisaCreditCard()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardNumberPart1, "4111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardNumberPart2, "1111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardNumberPart3, "1111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardNumberPart4, "1111");
        }
        
        [Given(@"I enter card owner name for Visa credit card")]
        public void GivenIEnterCardOwnerNameForVisaCreditCard()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardOwnerName, "Ivan Ivanov");
        }
        
        [Given(@"I enter card mounth and year for Visa credit card")]
        public void GivenIEnterCardMounthAndYearForVisaCreditCard()
        {
            //Add mounth and year to UI model
        }
        
        [Given(@"I enter card CVV code for Visa credit card")]
        public void GivenIEnterCardCVVCodeForVisaCreditCard()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.VisaCreditCard.CardCVV, "111");
        }
        
        [Given(@"I go to Visa d secure")]
        public void GivenIGoToVisaDSecure(int p0)
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Visa3dSecure);
        }
        
        [Given(@"I enter deposit amount for Visa d secure")]
        public void GivenIEnterDepositAmountForVisaDSecure(int p0)
        {
           Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.DepositAmount, "1");
        }
        
        [Given(@"I enter card number for Visa d secure")]
        public void GivenIEnterCardNumberForVisaDSecure(int p0)
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardNumberPart1, "4111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardNumberPart2, "1111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardNumberPart3, "1111");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardNumberPart4, "1111");
        }
        
        [Given(@"I enter card owner name for Visa d secure")]
        public void GivenIEnterCardOwnerNameForVisaDSecure(int p0)
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardOwnerName, "Ivan Ivanov");
        }
        
        [Given(@"I enter card mounth and year for Visa d secure")]
        public void GivenIEnterCardMounthAndYearForVisaDSecure(int p0)
        {
            //add month
        }
        
        [Given(@"I enter card CVV code for Visa d secure")]
        public void GivenIEnterCardCVVCodeForVisaDSecure(int p0)
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa3DSecure.CardCVV, "111");
        }
        
        [Given(@"I go to online wire transfer")]
        public void GivenIGoToOnlineWireTransfer()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.OnlineWireTransfer);
        }
        
        [Given(@"I enter deposit amount for online wire transfer")]
        public void GivenIEnterDepositAmountForOnlineWireTransfer()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.OnlineWireTransfer.Amount, "1");
        }
        
        [Given(@"I go to CashU")]
        public void GivenIGoToCashU()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.CASHU);
        }
        
        [Given(@"I enter deposit amount for CashU")]
        public void GivenIEnterDepositAmountForCashU()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.CashU.Amount, "1");
        }
        
        [Given(@"I go to Neteller")]
        public void GivenIGoToNeteller()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Neteller);
        }
        
        [Given(@"I enter deposit amount for Neteller")]
        public void GivenIEnterDepositAmountForNeteller()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Neteller.Amount, "1");
        }
        
        [Given(@"I go to Wallet One")]
        public void GivenIGoToWalletOne()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.WalletOne);
        }
        
        [Given(@"I enter deposit amount for Wallet One")]
        public void GivenIEnterDepositAmountForWalletOne()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.WalletOne.Amount, "1");
        }
        
        [Given(@"I go to Yandex money")]
        public void GivenIGoToYandexMoney()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.YandexMoney);
        }
        
        [Given(@"I enter deposit amount for Yandex money")]
        public void GivenIEnterDepositAmountForYandexMoney()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.YandexMoney.Amount, "1");
        }
        
        [Given(@"I go to Qiwi wallet")]
        public void GivenIGoToQiwiWallet()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.QiwiWallet);
        }
        
        [Given(@"I choose USD for Qiwi wallet")]
        public void GivenIChooseUSDForQiwiWallet()
        {
            App.Tap(Resources.Screen.Deposit.QiwiWallet.Currency);
            App.Tap(Resources.Screen.Deposit.QiwiWallet.USD);
        }
        
        [Given(@"I enter deposit amount for Qiwi wallet")]
        public void GivenIEnterDepositAmountForQiwiWallet()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.QiwiWallet.Amount, "1");
        }
        
        [Given(@"I go to Web money")]
        public void GivenIGoToWebMoney()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.WebMoney);
        }
        
        [Given(@"I enter deposit amount for Web money")]
        public void GivenIEnterDepositAmountForWebMoney()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.WebMoney.Amount, "1");
        }
        
        [Given(@"I go to YuuPay")]
        public void GivenIGoToYuuPay()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.YuuPay);
        }
        
        [Given(@"I choose USD for YuuPay")]
        public void GivenIChooseUSDForYuuPay()
        {
            App.Tap(Resources.Screen.Deposit.YuuPay.Currency);
            App.Tap(Resources.Screen.Deposit.YuuPay.USD);
        }
        
        [Given(@"I enter deposit amount for YuuPay")]
        public void GivenIEnterDepositAmountForYuuPay()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.YuuPay.Amount, "1");
        }
        
        [Given(@"I go to Moneta\.ru")]
        public void GivenIGoToMoneta_Ru()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.MonetaRu);
        }
        
        [Given(@"I enter deposit amount for Moneta\.ru")]
        public void GivenIEnterDepositAmountForMoneta_Ru()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.MonetaRu.Amount, "1");
        }
        
        [Given(@"I go to Boleto")]
        public void GivenIGoToBoleto()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.BoletoBankario);
        }
        
        [Given(@"I enter deposit amount for Boleto")]
        public void GivenIEnterDepositAmountForBoleto()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Boleto.Amount, "1");
        }
        
        [Given(@"I go to Astropay")]
        public void GivenIGoToAstropay()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Astropay);
        }
        
        [Given(@"I enter deposit amount for Astropay")]
        public void GivenIEnterDepositAmountForAstropay()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Astropay.Amount, "1");
        }
        
        [Given(@"I go to Alfa-Bank")]
        public void GivenIGoToAlfa_Bank()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.AlfaBank);
        }
        
        [Given(@"I enter deposit amount for Alfa-Bank")]
        public void GivenIEnterDepositAmountForAlfa_Bank()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.AlfaBank.Amount, "1");
        }
        
        [Given(@"I go to Promsvyazbank")]
        public void GivenIGoToPromsvyazbank()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Promsvyazbank);
        }
        
        [Given(@"I enter deposit amount for Promsvyazbank")]
        public void GivenIEnterDepositAmountForPromsvyazbank()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Promsvyazbank.Amount, "1");
        }
        
        [Given(@"I go to Aonpay Visa")]
        public void GivenIGoToAonpayVisa()
        {
            App.Back();
            App.Tap(Resources.Screen.Deposit.Deposit.Aonpay);
        }
        
        [Given(@"I enter deposit amount for Aonpay Visa")]
        public void GivenIEnterDepositAmountForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Amount, "1");
        }
        
        [Given(@"I enter first/last name for Aonpay Visa")]
        public void GivenIEnterFirstLastNameForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.FirstName, "Ivan");
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.LastName, "Ivanov");
        }
        
        [Given(@"I enter email for Aonpay Visa")]
        public void GivenIEnterEmailForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Email, "tvma@i.ua");
        }
        
        [Given(@"I enter phone for Aonpay Visa")]
        public void GivenIEnterPhoneForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Phone, "123456");
        }
        
        [Given(@"I enter country for Aonpay Visa")]
        public void GivenIEnterCountryForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Country, "Ukraine");
        }
        
        [Given(@"I enter city for Aonpay Visa")]
        public void GivenIEnterCityForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.City, "Dnipro");
        }
        
        [Given(@"I enter adress for Aonpay Visa")]
        public void GivenIEnterAdressForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Adress, "Aaaa");
        }
        
        [Given(@"I enter post index for Aonpay Visa")]
        public void GivenIEnterPostIndexForAonpayVisa()
        {
            Helper.EnterTextDeposit(Resources.Screen.Deposit.Visa.Email, "Ivan");
        }
        
        [When(@"I tap on button send for Visa credit card")]
        public void WhenITapOnButtonSendForVisaCreditCard()
        {
            App.Tap(Resources.Screen.Deposit.VisaCreditCard.BtnContinue);
        }
        
        [When(@"I tap on button send for Visa (.*)d secure")]
        public void WhenITapOnButtonSendForVisaDSecure(int p0)
        {
            App.Tap(Resources.Screen.Deposit.Visa3DSecure.BtnContinue);
        }
        
        [When(@"I tap on button send for online wire transfer")]
        public void WhenITapOnButtonSendForOnlineWireTransfer()
        {
            App.Tap(Resources.Screen.Deposit.OnlineWireTransfer.Send);
        }
        
        [When(@"I tap on button send for CashU")]
        public void WhenITapOnButtonSendForCashU()
        {
            App.Tap(Resources.Screen.Deposit.CashU.Send);
        }
        
        [When(@"I tap on button send for Neteller")]
        public void WhenITapOnButtonSendForNeteller()
        {
            App.Tap(Resources.Screen.Deposit.Neteller.Send);
        }
        
        [When(@"I tap on button send for Wallet One")]
        public void WhenITapOnButtonSendForWalletOne()
        {
            App.Tap(Resources.Screen.Deposit.WalletOne.Send);
        }
        
        [When(@"I tap on button send for Yandex money")]
        public void WhenITapOnButtonSendForYandexMoney()
        {
            App.Tap(Resources.Screen.Deposit.YandexMoney.Send);
        }
        
        [When(@"I tap on button send for Qiwi wallet")]
        public void WhenITapOnButtonSendForQiwiWallet()
        {
            App.Tap(Resources.Screen.Deposit.QiwiWallet.Send);
        }
        
        [When(@"I tap on button send for Web money")]
        public void WhenITapOnButtonSendForWebMoney()
        {
            App.Tap(Resources.Screen.Deposit.WebMoney.Send);
        }
        
        [When(@"I tap on button send for YuuPay")]
        public void WhenITapOnButtonSendForYuuPay()
        {
            App.Tap(Resources.Screen.Deposit.YuuPay.Send);
        }
        
        [When(@"I tap on button send Moneta\.ru")]
        public void WhenITapOnButtonSendMoneta_Ru()
        {
            App.Tap(Resources.Screen.Deposit.MonetaRu.Send);
        }
        
        [When(@"I tap on button send for Boleto")]
        public void WhenITapOnButtonSendForBoleto()
        {
            App.Tap(Resources.Screen.Deposit.Boleto.Send);
        }
        
        [When(@"I tap on button send for Astropay")]
        public void WhenITapOnButtonSendForAstropay()
        {
            App.Tap(Resources.Screen.Deposit.Astropay.Send);
        }
        
        [When(@"I tap on button send for Alfa-Bank")]
        public void WhenITapOnButtonSendForAlfa_Bank()
        {
            App.Tap(Resources.Screen.Deposit.AlfaBank.Send);
        }
        
        [When(@"I tap on button send for Promsvyazbank")]
        public void WhenITapOnButtonSendForPromsvyazbank()
        {
            App.Tap(Resources.Screen.Deposit.Promsvyazbank.Send);
        }
        
        [When(@"I tap on button send for Aonpay Visa")]
        public void WhenITapOnButtonSendForAonpayVisa()
        {
            App.Tap(Resources.Screen.Deposit.Visa.Send);
        }
        
        [Then(@"the result should be Visa deposit page")]
        public void ThenTheResultShouldBeVisaDepositPage()
        {
            App.WaitForElement(Resources.Screen.Deposit.VisaCreditCard.DepositAmount, timeout: TimeSpan.FromSeconds(30));
        }
        
        [Then(@"the result i sholud see is account balance increased by deposit amount")]
        public void ThenTheResultISholudSeeIsAccountBalanceIncreasedByDepositAmount()
        {
            double newBalance = Helper.CheckBalance();
            double prevBalance = ScenarioContext.Current.Get<double>("AccountBalance");
            NUnitFramework.Assert.AreEqual(prevBalance+1, newBalance);
        }
    }
}
